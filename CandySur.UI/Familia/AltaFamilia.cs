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

namespace CandySur.UI.Familia
{
    public partial class AltaFamilia : Form
    {
        private SEG.Entity.SessionManager Session;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Familia familiaService = new SEG.Service.Familia();
        public AltaFamilia()
        {
            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();
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
                    SEG.Entity.Familia familia = new SEG.Entity.Familia
                    {
                        Compuesto = true,
                        Descripcion = txtDescripcion.Text,
                        Nombre = txtNombre.Text,
                        Eliminado = false
                    };

                    familiaService.Alta(familia);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Descripcion = "Familia dada de alta. " + txtNombre.Text
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
            if (txtNombre.Text == "")
            {
                return "El campo nombre es requerido";
            }
            if (txtDescripcion.Text == "")
            {
                return "El campo descripcion es requerido";
            }

            return string.Empty;
        }



    }
}
