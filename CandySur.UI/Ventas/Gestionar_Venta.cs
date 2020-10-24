using CandySur.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI
{
    public partial class Gestionar_Venta : Form
    {
        private SEG.Service.SessionManager Session;
        CandySur.BLL.Venta ventaService = new CandySur.BLL.Venta();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        CandySur.BE.Venta venta;

        public Gestionar_Venta()
        {
            InitializeComponent();
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNumeroVenta.Text))
                {
                    MessageBox.Show("El campo numero de venta es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    venta = ventaService.ObtenerDetalle(int.Parse(txtNumeroVenta.Text));

                    this.dvgProductosIncluidos.DataSource = venta.Detalles.Select(x => new { Producto = x.Producto.Descripcion, Cantidad = x.Cantidad, Importe = x.Importe }).ToList();

                    this.lblImporteTotal.Text = "$ " + venta.Importe;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (venta == null)
                {
                    MessageBox.Show("Se debe realizar la busqueda previo a presionar el boton eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ventaService.Eliminar(venta);

                    LimpiarCampos();

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)SEG.Util.Enums.Criticidad.Media,
                        Fecha = DateTime.Now,
                        Descripcion = "Venta eliminada. " + txtNumeroVenta.Text
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Venta eliminada con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            this.txtNumeroVenta.Text = string.Empty;
            this.venta = null;
            this.dvgProductosIncluidos.DataSource = null;
        }
    }
}
