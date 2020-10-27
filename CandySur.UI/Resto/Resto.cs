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

namespace CandySur.UI.Resto
{
    public partial class Resto : Form
    {
        private CandySur.BE.Venta venta;
        private UI.Venta formVenta;
        private SEG.Service.SessionManager Session;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        public Resto(BE.Venta venta, UI.Venta formVenta)
        {
            InitializeComponent();

            //Set variables privadas.
            this.venta = venta;
            this.formVenta = formVenta;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(this.txtMontoAbonado.Text) && Convert.ToDecimal(this.txtMontoAbonado.Text.Replace(".",",")) >= this.venta.Importe && Convert.ToDecimal(this.txtMontoAbonado.Text.Replace(".", ",")) != 0)
                {
                    CandySur.BLL.Cobro cobroService = new CandySur.BLL.Cobro();

                    this.txtResto.Text = (cobroService.Calcular(Convert.ToDecimal(this.txtSubTotal.Text.Replace(".", ",")), Convert.ToDecimal(this.txtMontoAbonado.Text.Replace(".", ",")))).ToString();
                }
                else
                {
                    throw new Exception("Se debe ingresar el monto abonado valido previo a calcular.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Venta ventaService = new BLL.Venta();

                ventaService.Alta(venta);

                SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                {
                    IdUsuario = Session.Usuario.Id,
                    IdCriticidad = (int)Enums.Criticidad.Baja,
                    Fecha = DateTime.Now,
                    Descripcion = "Venta concretada."
                };

                bitacoraService.Registrar(reg);

                //Muestro el mensaje y cierro form.
                DialogResult result = MessageBox.Show("Venta concretada correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.Close();
                    this.formVenta.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resto_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtSubTotal.Text = this.venta.Importe.ToString();

                BLL.Descuento descuentosService = new BLL.Descuento();

                List<CandySur.BE.Descuento> descuentos = descuentosService.Listar();

                BE.Descuento descuento = descuentosService.CalcularDescuentos(descuentos, this.venta.Importe);

                if (descuento != null)
                {
                    this.txtDescuentoAplicado.Text = ((descuento.Porcentaje * this.venta.Importe) / 100).ToString();
                    this.venta.Importe -= Convert.ToDecimal(this.txtDescuentoAplicado.Text);
                    this.txtImporteTotal.Text = this.venta.Importe.ToString();
                }

                //Focus.
                this.BringToFront();
                this.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
