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

namespace CandySur.UI.Paquete
{
    public partial class Alta_Paquete : Form
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        List<BE.Golosina> golosinasIncluidas = new List<BE.Golosina>();
        BE.Golosina golosinaBuscada;
        BLL.Golosina golosinaService = new BLL.Golosina();
        BLL.Paquete paqueteService = new BLL.Paquete();
        public Alta_Paquete()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCodProducto.Text))
                {
                    MessageBox.Show("El campo codigo producto es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.golosinaBuscada = golosinaService.ObtenerDetalle(int.Parse(txtCodProducto.Text));

                    txtDescripcionGolosina.Text = this.golosinaBuscada.Descripcion;
                    txtStockGolosina.Text = this.golosinaBuscada.Stock.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (golosinaBuscada != null)
            {
                if(Convert.ToInt32(txtCantidadGolosina.Text) > golosinaBuscada.Stock)
                {
                    MessageBox.Show("La cantidad a ingresar supera el stock disponible de la golosina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(txtCantidadGolosina.Text) <= 0)
                {
                    MessageBox.Show("La cantidad a ingresar debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(golosinasIncluidas.Any(g=> g.Id == golosinaBuscada.Id))
                {
                    MessageBox.Show("La golosina seleccionada ya se encuentra agregada en el paquete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    golosinaBuscada.Cantidad = Convert.ToInt32(txtCantidadGolosina.Text);

                    golosinasIncluidas.Add(golosinaBuscada);

                    CalcularPrecio();

                    this.dgvGolosinasIncluidas.DataSource = golosinasIncluidas.Select(x => new { Id = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Cantidad = x.Cantidad }).ToList();

                    LimpiarCamposGolosina();
                }
            }
            else
            {
                MessageBox.Show("Se debe buscar una golosina previo presionar el boton (+).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (this.dgvGolosinasIncluidas.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvGolosinasIncluidas.SelectedRows[0].Cells["Id"].Value.ToString());
            
                golosinasIncluidas.Remove(golosinasIncluidas.FirstOrDefault(x=> x.Id == id));

                CalcularPrecio();

                this.dgvGolosinasIncluidas.DataSource = golosinasIncluidas.Select(x => new { Id = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Cantidad = x.Cantidad }).ToList();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una golosina de la grilla previo presionar el boton (-).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    BE.Paquete paquete = new BE.Paquete
                    {
                        Descripcion = txtDescripcion.Text,
                        Stock = int.Parse(txtStock.Text),
                        Eliminado = false,
                        Importe = Decimal.Parse(lblPrecioTotal.Text.Replace(".", ",")),
                        Golosinas = this.golosinasIncluidas
                    };

                    paqueteService.Alta(paquete);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Paquete dado de alta. " + txtDescripcion.Text
                    };

                    bitacoraService.Registrar(reg);

                    this.LimpiarCampos();

                    MessageBox.Show("Paquete dado de alta correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularPrecio()
        {
            decimal precio = 0;

            foreach (BE.Golosina item in golosinasIncluidas)
            {
                precio += item.Importe;
            }

            this.lblPrecioTotal.Text = precio.ToString().Replace(".", ",");
        }

        private string ValidarCampos()
        {
            if (txtDescripcion.Text == "")
            {
                return "El campo descripcion es requerido";
            }
            if (txtStock.Text == "")
            {
                return "El campo stock es requerido";
            }
            if (golosinasIncluidas.Count == 0)
            {
                return "Se debe agregar golosinas al paquete previo a finalizar";
            }
            if (golosinasIncluidas.Count == 1)
            {
                return "Se deben agregar al menos 2 productos.";
            }

            return string.Empty;
        }

        private void LimpiarCampos()
        {
            this.txtDescripcion.Text = string.Empty;
            this.txtStock.Text = string.Empty;
            this.lblPrecioTotal.Text = "$ 0";
            LimpiarCamposGolosina();

            this.golosinaBuscada = null;
            this.golosinasIncluidas.Clear();
            this.dgvGolosinasIncluidas.DataSource = null;
        }

        private void LimpiarCamposGolosina()
        {
            this.txtCantidadGolosina.Text = string.Empty;
            this.txtCodProducto.Text = string.Empty;
            this.txtDescripcionGolosina.Text = string.Empty;
            this.txtStockGolosina.Text = string.Empty;
        }
    }
}
