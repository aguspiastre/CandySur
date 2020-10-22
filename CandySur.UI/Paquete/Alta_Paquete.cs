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
        List<BE.Producto> golosinasIncluidas = new List<BE.Producto>();
        BE.Golosina golosinaBuscada;
        BE.Golosina golosinaAEliminar;
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
                    BE.Golosina golosina = golosinaService.ObtenerDetalle(int.Parse(txtCodProducto.Text));

                    txtDescripcion.Text = golosina.Descripcion;
                    txtStock.Text = golosina.Stock.ToString();
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
                else if(golosinasIncluidas.Any(g=> g.Id == golosinaBuscada.Id))
                {
                    MessageBox.Show("La golosina seleccionada ya se encuentra agregada en el paquete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    golosinasIncluidas.Add(golosinaBuscada);

                    CalcularPrecio();

                    this.dgvGolosinasIncluidas.DataSource = golosinasIncluidas.Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Stock = x.Stock }).ToList();

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
            if (golosinaAEliminar != null)
            {
                BE.Golosina golosina = (BE.Golosina)golosinasIncluidas.FirstOrDefault(g => g.Id == golosinaAEliminar.Id);

                golosinasIncluidas.Remove(golosina);

                golosinaAEliminar = null;

                CalcularPrecio();

                this.dgvGolosinasIncluidas.DataSource = golosinasIncluidas.Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Stock = x.Stock }).ToList();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar una golosina de la grilla previo presionar el boton (-).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGolosinasIncluidas_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGolosinasIncluidas.SelectedRows)
            {
                golosinaAEliminar = (BE.Golosina)row.DataBoundItem;
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
                        Importe = int.Parse(lblPrecioTotal.Text),
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

                    MessageBox.Show("Familia dada de alta correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            this.lblPrecioTotal.Text = "$ " + precio.ToString();
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

            return string.Empty;
        }

        private void LimpiarCampos()
        {
            this.txtDescripcion.Text = string.Empty;
            this.txtStock.Text = string.Empty;
            this.lblPrecioTotal.Text = "$ 0";
            LimpiarCamposGolosina();

            golosinaBuscada = null;
            golosinaAEliminar = null;
            golosinasIncluidas.Clear();
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
