using CandySur.SEG.Entity;
using CandySur.SEG.Service;
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
    public partial class Venta : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        BLL.Paquete paqueteService = new BLL.Paquete();
        BLL.Golosina golosinaService = new BLL.Golosina();
        BE.Producto productoBuscado;
        BE.Venta venta = new BE.Venta();

        public Venta()
        {
            InitializeComponent();

            this.rdbProducto.Checked = true;
            this.rdbPaquete.Checked = false;

            this.lblCodProducto.Text = "Codigo Producto:";
            this.btnBuscarProducto.Visible = true;
            this.txtCodProducto.Visible = true;
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
                if (venta.Detalles.Any(d=> d.Producto.Id == productoBuscado.Id && d.Producto.Descripcion == productoBuscado.Descripcion))
                    throw new Exception("El producto ya se encuentra ingresado.");

                if (txtCantidad.Text == string.Empty)
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

                    this.lblImporteTotalGenerarVenta.Text = "$ " + this.venta.Importe;

                    this.dgvDetalles.DataSource = this.venta.Detalles.Select(x => new { Codigo = x.Producto.Id, Tipo = x.Producto is BE.Golosina ? "Golosina" : "Paquete", Producto = x.Producto.Descripcion, Cantidad = x.Cantidad, Importe = x.Importe }).ToList();
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

                    this.lblImporteTotalGenerarVenta.Text = "$ " + this.venta.Importe;

                    this.dgvDetalles.DataSource = this.venta.Detalles.Select(x => new { Codigo = x.Producto.Id, Tipo = x.Producto is BE.Golosina ? "Golosina" : "Paquete", Producto = x.Producto.Descripcion, Cantidad = x.Cantidad, Importe = x.Importe }).ToList();
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

        private void Venta_Load(object sender, EventArgs e)
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

        public void ActualizarIdioma(SEG.Entity.Idioma idioma)
        {
            this.Traducir();
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
                case "Generar Venta":
                    this.btnAvanzar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
