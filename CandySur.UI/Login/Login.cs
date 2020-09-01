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

namespace CandySur.UI.Login
{
    public partial class Login : Form
    {
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.DigitoVerificador digitoverificadorService = new SEG.Service.DigitoVerificador();
        public bool VisualizarRestablecerSistema = true;

        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

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
                    SEG.Entity.SessionManager.Login(usuario);

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
                        this.DialogResult = DialogResult.Abort;
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
    }
}
