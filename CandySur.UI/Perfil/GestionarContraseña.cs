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

namespace CandySur.UI.Perfil
{
    public partial class GestionarContraseña : Form
    {
        private CandySur.SEG.Entity.SessionManager Session;
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();

        public GestionarContraseña()
        {
            Session = SEG.Entity.SessionManager.GetInstance();

            InitializeComponent();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
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
                    usuarioService.CambiarContraseña(Session.Usuario.Nombre, txtContraseñaActual.Text, txtRepetirpw.Text);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Media,
                        Fecha = DateTime.Now,
                        Descripcion = "Contraseña modificada."
                    };

                    bitacoraService.Registrar(reg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string ValidarCampos()
        {

            if (txtNuevapw.Text  == "")
            {
                return "El campo nueva contraseña es requerido.";
            }
            if (txtRepetirpw.Text == "")
            {
                return "El campo repetir contraseña es requerido.";
            }
            if (txtContraseñaActual.Text == "")
            {
                return "El campo contraseña actual es requerido.";
            }
            if (txtNuevapw.Text != txtRepetirpw.Text)
            {
                return "Las contraseñas no coinciden.";
            }

            return string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
