using CandySur.SEG.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CandySur.SEG.Util.Enums;
using CandySur.SEG.Entity;

namespace CandySur.UI.Login
{
    public partial class Login : Form, IIdiomaObserver
    {
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.DigitoVerificador digitoverificadorService = new SEG.Service.DigitoVerificador();
        private SEG.Service.IdiomaManager idiomaManager;
        private SEG.Entity.Idioma Idioma;
        public bool VisualizarRestablecerSistema = true;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.idiomaManager = SEG.Service.IdiomaManager.GetInstance();
            SEG.Service.IdiomaManager.Suscribir(this);
            Traducir();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                string validarCampos = this.ValidarCampos(nombreUsuario, contraseña);

                if (!String.IsNullOrEmpty(validarCampos))
                {
                    MessageBox.Show(validarCampos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool verificarIntegridad = digitoverificadorService.VerificarIntegridad();

                    SEG.Entity.Usuario usuario = usuarioService.Consultar(txtUsuario.Text);
                    contraseña = SEG.Util.Encrypt.Encriptar(contraseña, (int)TipoEncriptacion.Irreversible);

                    //Busco los permisos del usuario.
                    usuario.Permisos = usuarioService.ObtenerPermisos(usuario);

                    // Valido si es o no administrador
                    bool esAdministrador = usuario.Permisos.Any(p => p.Nombre == "Administrador");

                    bool contraseñaCorrecta = usuarioService.CompararContraseña(usuario.Contraseña, contraseña);

                    if (!verificarIntegridad && !esAdministrador)
                        throw new Exception("La base de datos no se encuentra en un estado correcto, si el problema persiste contactarse con el administrador.");

                    // Valido el estado bloqueado
                    bool usuarioBloqueado = usuarioService.ValidarEstado(usuario);

                    if (usuarioBloqueado && !esAdministrador)
                        throw new Exception("El usuario se encuentra bloqueado.");

                    if (!contraseñaCorrecta)
                    {
                        if (!esAdministrador)
                        {
                            usuario.Reintentos = usuarioService.AumentarContador(usuario);

                            if (usuario.Reintentos >= 3)
                            {
                                usuarioService.BloquearUsuario(usuario);

                                bitacoraService.Registrar(new SEG.Entity.Bitacora
                                {
                                    IdCriticidad = (int)Criticidad.Baja,
                                    Descripcion = "Usuario bloqueado. " + usuario.NombreUsuario,
                                    IdUsuario = usuario.Id,
                                    Fecha = DateTime.Now
                                });

                                throw new Exception("Usuario bloqueado debido a que realizó 3 intentos de ingreso incorrectos.");
                            }
                        }

                        throw new Exception("Contraseña incorrecta");
                    }

                    // Logueo.
                    SEG.Service.SessionManager.Login(usuario);

                    // Reinicio el contador
                    usuarioService.ReiniciarContador(usuario);

                    //Registro en bitacora 
                    bitacoraService.Registrar(new SEG.Entity.Bitacora
                    {
                        IdCriticidad = (int)Criticidad.Baja,
                        Descripcion = "Usuario logueado con exito. " + usuario.NombreUsuario,
                        IdUsuario = usuario.Id,
                        Fecha = DateTime.Now
                    });

                    this.DialogResult = DialogResult.OK;

                    if (!verificarIntegridad && esAdministrador)
                    {
                        MessageBox.Show("La base de datos no se encuentra en un estado correcto, sera redirigido para resolver los errores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.DialogResult = DialogResult.Abort;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarCampos(string usuario, string contraseña)
        {
            if (usuario == "")
            {
                return "El campo usuario es requerido";
            }
            if (contraseña == "")
            {
                return "El campo contraseña es requerido";
            }

            return string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            SEG.Service.IdiomaManager.Desuscribir(this);
        }

        public void ActualizarIdioma(SEG.Entity.Idioma idioma)
        {
            this.Traducir(idioma);
        }

        private void Traducir(SEG.Entity.Idioma idioma = null)
        {
            SEG.Service.Traductor traductor = new Traductor();

            var traducciones = traductor.ObtenerTraducciones(idioma);

            //Menu.
            this.lblContraseña.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.txtContraseña.Name).Descripcion;

            this.lblUsuario.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.txtUsuario.Name).Descripcion;

            this.btnCancelarLogin.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.btnCancelarLogin.Name).Descripcion;

            this.btnIngresar.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.btnIngresar.Name).Descripcion;

            this.linkGenerarContraseña.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.linkGenerarContraseña.Name).Descripcion;

            this.menuIdioma.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.menuIdioma.Name).Descripcion;

            this.SubMenuEspañol.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuEspañol.Name).Descripcion;

            this.SubMenuIngles.Text = traducciones.FirstOrDefault(t => t.Etiqueta == this.SubMenuIngles.Name).Descripcion;
        }

        private void SubMenuEspañol_Click(object sender, EventArgs e)
        {
            // TODO MEJORAR ESTO.
            Idioma = new SEG.Entity.Idioma
            {
                Id = 1,
                Nombre = "Español",
                Principal = true
            };

            SEG.Service.IdiomaManager.CambiarIdioma(Idioma);

        }

        private void SubMenuIngles_Click(object sender, EventArgs e)
        {
            // TODO MEJORAR ESTO.
            Idioma = new SEG.Entity.Idioma
            {
                Id = 2,
                Nombre = "Ingles",
                Principal = false
            };

            SEG.Service.IdiomaManager.CambiarIdioma(Idioma);
        }
    }
}
