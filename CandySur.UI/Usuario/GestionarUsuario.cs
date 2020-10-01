using CandySur.SEG.Entity;
using CandySur.SEG.Service;
using CandySur.SEG.Util;
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

namespace CandySur.UI.Usuario
{
    public partial class GestionarUsuario : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Entity.Usuario usuario;

        public GestionarUsuario()
        {
            InitializeComponent();
        }
        private void GestionarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                Session = SEG.Service.SessionManager.GetInstance();

                this.validarPermisos(Session);

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario == null)
                {
                    MessageBox.Show("Realizar la busqueda del usuario previo a presionar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (usuario.NombreUsuario == Session.Usuario.NombreUsuario)
                        throw new Exception("El usuario a eliminar es el mismo que se encuentra logueado.");

                    usuarioService.Eliminar(usuario);

                    LimpiarCampos();

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Usuario eliminado. " + txtUsername.Text
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Usuario eliminado con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("El campo nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usuario = usuarioService.Consultar(txtUsername.Text);

                    txtEmail.Text = usuario.Mail;
                    txtApellido.Text = usuario.Apellido;
                    txtDni.Text = usuario.DNI.ToString();
                    txtNombrePersonal.Text = usuario.Nombre;
                    txtTelefono.Text = usuario.Telefono.ToString();
                    txtDireccion.Text = usuario.Direccion;
                    dtpFechaNac.Value = usuario.FechaNac.Date;

                    this.btnDesbloquear.Visible = usuario.Bloqueado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario == null)
                {
                    MessageBox.Show("Realizar la busqueda del usuario previo a presionar modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usuario.Direccion = txtDireccion.Text;
                    usuario.Telefono = Convert.ToInt32(txtTelefono.Text.ToString());
                    usuario.Mail = txtEmail.Text;
                    usuario.FechaNac = dtpFechaNac.Value.Date;

                    usuarioService.Modificar(usuario, false);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Usuario modificado. " + txtUsername.Text
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Usuario modificado con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario == null)
                {
                    MessageBox.Show("Realizar la busqueda del usuario previo a presionar desbloquear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usuarioService.Desbloquear(usuario);

                    bitacoraService.Registrar(new SEG.Entity.Bitacora
                    {
                        IdCriticidad = (int)Criticidad.Baja,
                        Descripcion = "Usuario desbloqueado. " + usuario.NombreUsuario,
                        IdUsuario = Session.Usuario.Id,
                        Fecha = DateTime.Now
                    });

                    this.btnDesbloquear.Visible = false;

                    MessageBox.Show("Usuario desbloqueado con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            usuario = null;

            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtNombrePersonal.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Now;
        }

        public void ActualizarIdioma(SEG.Entity.Idioma idioma)
        {
            this.Traducir();
        }

        private void Traducir()
        {
            SEG.Service.Traductor traductor = new Traductor();
            var idiomaManager = SEG.Service.IdiomaManager.GetInstance();

            var traducciones = traductor.ObtenerTraducciones(idiomaManager.Idioma);

            foreach (Control item in this.Controls)
            {
                if (traducciones.Any(t => t.Etiqueta == item.Name))
                {
                    item.Text = traducciones.FirstOrDefault(t => t.Etiqueta == item.Name).Descripcion;
                }

                TraducirControlesInternos(item, traducciones);
            }
        }

        private void TraducirControlesInternos(Control item, List<Traduccion> traducciones)
        {
            if (item is GroupBox)
            {
                foreach (Control subItem in item.Controls)
                {
                    if (traducciones.Any(t => t.Etiqueta == subItem.Name))
                    {
                        subItem.Text = traducciones.FirstOrDefault(t => t.Etiqueta == subItem.Name).Descripcion;
                    }

                    TraducirControlesInternos(subItem, traducciones);
                }
            }
        }

        private void GestionarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            SEG.Service.IdiomaManager.Desuscribir(this);
        }

        private void validarPermisos(SEG.Service.SessionManager Session)
        {
            bool contienePermisos = false;

            foreach (var item in Session.Usuario.Permisos)
            {
                if (item is SEG.Entity.Familia)
                {
                    SEG.Entity.Familia familia = (SEG.Entity.Familia)item;

                    foreach (SEG.Entity.Patente patente in familia.Permisos)
                    {
                        this.validarPatente(patente, ref contienePermisos);
                    }
                }
                else
                {
                    SEG.Entity.Patente patente = (SEG.Entity.Patente)item;

                    this.validarPatente(patente, ref contienePermisos);
                }
            }

            if (!contienePermisos)
                throw new Exception("No tenes los permisos necesarios para ingresar a esta funcionalidad");
        }

        private void validarPatente(SEG.Entity.Patente patente, ref bool contienePermisos)
        {
            switch (patente.Nombre)
            {
                case "Desbloquear Usuario":
                    this.btnDesbloquear.Visible = true;
                    contienePermisos = true;
                    break;
                case "Modificar Usuario":
                    this.btnModificar.Visible = true;
                    contienePermisos = true;
                    break;
                case "Eliminar Usuario":
                    this.btnEliminar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }
    }
}
