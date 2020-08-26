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

namespace CandySur.UI.Usuario
{
    public partial class GestionarUsuario : Form
    {
        private SEG.Entity.SessionManager Session;
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Entity.Usuario usuario;

        public GestionarUsuario()
        {
            InitializeComponent();
        }
        private void GestionarUsuario_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();
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

                    usuarioService.Modificar(usuario);

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
                    MessageBox.Show("Realizar la busqueda del usuario previo a presionar modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usuarioService.Desbloquear(usuario);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Media,
                        Fecha = DateTime.Now,
                        Descripcion = "Usuario desbloqueado. " + txtUsername.Text
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
    }
}
