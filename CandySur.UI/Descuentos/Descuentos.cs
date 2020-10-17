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

namespace CandySur.UI.Descuentos
{
    public partial class Descuentos : Form
    {
        private SEG.Service.SessionManager Session;
        CandySur.BLL.Descuento descuentoService = new CandySur.BLL.Descuento();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();

        public Descuentos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    CandySur.BE.Descuento d = new CandySur.BE.Descuento
                    {
                        Importe = Convert.ToDecimal(txtImporte.Text),
                        Porcentaje = Convert.ToDecimal(txtPorcentaje.Text),
                    };

                    descuentoService.Configurar(d);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Media,
                        Fecha = DateTime.Now,
                        Descripcion = "Descuento dado de alta."
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Descuento dado de alta correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarCampos()
        {
            if (txtImporte.Text == "")
            {
                return "El campo importe es requerido";
            }
            if (txtPorcentaje.Text == "")
            {
                return "El campo porcenaje es requerido";
            }

            if(Convert.ToDecimal(txtPorcentaje.Text) >= 100)
            {
                return "El campo porcenaje no puede ser mayor o igual a 100.";
            }

            return string.Empty;
        }
    }
}
