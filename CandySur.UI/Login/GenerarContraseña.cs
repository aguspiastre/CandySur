using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI.Login
{
    public partial class GenerarContraseña : Form
    {
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

        public GenerarContraseña()
        {
            InitializeComponent();
        }

        private void btnGenerarContraseña_Click(object sender, EventArgs e)
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
                    usuarioService.GenerarContraseña(txtUsuario.Text, txtEmail.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarCampos()
        {
            if (txtUsuario.Text == "")
            {
                return "El campo usuario es requerido";
            }
            if (txtEmail.Text == "")
            {
                return "El campo usuario es requerido";
            }

            return string.Empty;
        }
    }
}
