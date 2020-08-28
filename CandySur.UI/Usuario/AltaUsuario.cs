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
    public partial class AltaUsuario : Form
    {
        private SEG.Entity.SessionManager Session;

        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            this.txtUsername.Text = "";
            this.txtUsername.Text = txtNombre.Text.ToLower() + "." + txtApellido.Text.ToLower();
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            this.txtUsername.Text = "";
            this.txtUsername.Text = txtNombre.Text.ToLower() + "." + txtApellido.Text.ToLower();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                string validarCampos = this.ValidarCampos();

                if (!String.IsNullOrEmpty(validarCampos))
                {
                    MessageBox.Show(validarCampos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SEG.Entity.Usuario user = new SEG.Entity.Usuario
                    {
                        NombreUsuario = txtUsername.Text,
                        Apellido = txtApellido.Text,
                        Telefono = Convert.ToDecimal(txtTelefono.Text),
                        Direccion = txtDireccion.Text,
                        DNI = Convert.ToDecimal(txtDni.Text),
                        Mail = txtEmail.Text,
                        Nombre = txtNombre.Text,
                        FechaNac = dateFechaNacimiento.Value,
                        Bloqueado = false,
                        Eliminado = false,
                        Reintentos = 0,
                    };

                    usuarioService.AltaUsuario(user);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Usuario dado de alta. " + txtUsername.Text
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Usuario dado de alta correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarCampos()
        {
            if (txtApellido.Text == "")
            {
                return "El campo apellido es requerido";
            }
            if (txtNombre.Text == "")
            {
                return "El campo nombre es requerido";
            }
            if (txtDni.Text == "")
            {
                return "El campo DNI es requerido";
            }
            if (txtDireccion.Text == "")
            {
                return "El campo direccion es requerido";
            }
            if (txtEmail.Text == "")
            {
                return "El campo email es requerido";
            }
            if (txtTelefono.Text == "")
            {
                return "El campo telefono es requerido";
            }

            return string.Empty;
        }
    }
}
