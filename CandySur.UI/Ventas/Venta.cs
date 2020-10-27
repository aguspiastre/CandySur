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
    public partial class Venta : Form
    {
        BLL.Paquete paqueteService = new BLL.Paquete();
        BLL.Golosina golosinaService = new BLL.Golosina();
        BE.Producto productoBuscado;
        BE.Venta venta = new BE.Venta();

        public Venta()
        {
            InitializeComponent();

            this.rdbProducto.Checked = true;
            this.rdbPaquete.Checked = false;

            this.lblTipoProducto.Text = "Codigo Producto:";
            this.btnBuscarProducto.Visible = true;
            this.txtCodProducto.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdbProducto.Checked == false)
            {
                this.lblTipoProducto.Text = "Paquete:";
                this.btnBuscarProducto.Visible = false;
                this.txtCodProducto.Visible = false;
                this.cboPaquetes.Visible = true;
            }
            else
            {
                this.lblTipoProducto.Text = "Codigo Producto:";
                this.btnBuscarProducto.Visible = true;
                this.txtCodProducto.Visible = true;
                this.cboPaquetes.Visible = false;
            }

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCodProducto.Text))
                {
                    MessageBox.Show("El codigo producto es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (rdbPaquete.Checked)
                    {
                        productoBuscado = paqueteService.ObtenerDetalle(int.Parse(txtCodProducto.Text));
                    }
                    else
                    {
                        productoBuscado = golosinaService.ObtenerDetalle(int.Parse(txtCodProducto.Text));
                    }

                    txtPrecio.Text = productoBuscado.Importe.ToString();
                    txtDescripcion.Text = productoBuscado.Descripcion;
                    txtPrecio.Text = productoBuscado.Importe.ToString();
                    txtStock.Text = productoBuscado.Stock.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCantidad.Text == string.Empty)
                    throw new Exception("El campo cantidad es requerido.");

                if (int.Parse(txtCantidad.Text) == 0)
                    throw new Exception("La cantidad a ingresar no puede ser 0");

                if (int.Parse(txtCantidad.Text) <= productoBuscado.Stock)
                {
                    venta.AgregarProducto(new BE.Detalle_Venta
                    {
                        Cantidad = int.Parse(txtCantidad.Text),
                        Importe = Decimal.Parse(txtPrecio.Text.Replace(".", ",")),
                        Producto = productoBuscado,
                        Eliminado = false
                    });

                    this.lblImporteTotal.Text = "$ " + this.venta.Importe;

                    this.dgvDetalles.DataSource = this.venta.Detalles.Select(x => new { Codigo = x.Producto.Id, Tipo = productoBuscado is BE.Golosina ? "Golosina" : "Paquete", Producto = x.Producto.Descripcion, Cantidad = x.Cantidad, Importe = x.Importe }).ToList();
                }
                else
                {
                    throw new Exception("No hay stock suficiente del producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSacarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvDetalles.SelectedRows.Count > 0)
                {
                    int codigo = Convert.ToInt32(dgvDetalles.SelectedRows[0].Cells["Codigo"].Value.ToString());
                    string tipoProducto = dgvDetalles.SelectedRows[0].Cells["Producto"].Value.ToString();

                    venta.EliminarProducto(codigo, tipoProducto);

                    this.lblImporteTotal.Text = "$ " + this.venta.Importe;

                    this.dgvDetalles.DataSource = this.venta.Detalles.Select(x => new { Codigo = x.Producto.Id, Tipo = productoBuscado is BE.Golosina ? "Golosina" : "Paquete", Producto = x.Producto.Descripcion, Cantidad = x.Cantidad, Importe = x.Importe }).ToList();
                }
                else
                {
                    throw new Exception("Se debe seleccionar un producto previo a eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.venta.Detalles.Count > 0)
                {
                    this.VisualizarPantallaCobro();
                }
                else
                {
                    throw new Exception("Se debe incluir al menos un producto previo a avanzar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VisualizarPantallaCobro()
        {
            UI.Resto.Resto resto = new Resto.Resto(this.venta, this);
            resto.ShowDialog();
        }
    }
}
