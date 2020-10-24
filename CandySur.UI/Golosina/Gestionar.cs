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

namespace CandySur.UI.Golosina
{
    public partial class Gestionar : Form
    {
        BLL.Golosina golosinaService = new BLL.Golosina();
        BE.Golosina golosina;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        private SEG.Service.SessionManager Session;

        public Gestionar()
        {
            InitializeComponent();
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
                    golosina = golosinaService.ObtenerDetalle(int.Parse(txtCodProducto.Text));

                    txtDescripcion.Text = golosina.Descripcion;
                    txtPrecio.Text = golosina.Importe.ToString();
                    txtStock.Text = golosina.Stock.ToString();
                    txtStockAlerta.Text = golosina.AlertaStock.ToString();

                    //Datos del proveedor
                    txtEmail.Text = golosina.Proveedor.Mail;
                    txtTelefono.Text = golosina.Proveedor.Telefono.ToString();
                    txtRazonSocial.Text = golosina.Proveedor.RazonSocial;
                    txtCuit.Text = golosina.Proveedor.Cuit;
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
                if (golosina == null)
                {
                    MessageBox.Show("Se debe buscar una golosina previo a intentar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    golosinaService.Eliminar(golosina);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Golosina eliminada. " + this.txtDescripcion.Text
                    };

                    bitacoraService.Registrar(reg);

                    LimpiarCampos();

                    MessageBox.Show("Golosina modificada con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtStockAlerta.Text = string.Empty;
            golosina = null;

            //Datos del proveedor
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtCuit.Text = string.Empty;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (golosina == null)
                {
                    MessageBox.Show("Se debe buscar una golosina previo a intentar modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string validarCampos = this.ValidarCampos();

                    if (!String.IsNullOrEmpty(validarCampos))
                    {
                        MessageBox.Show(validarCampos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        golosina.AlertaStock = int.Parse(txtStockAlerta.Text);
                        golosina.Stock = int.Parse(txtStock.Text);
                        golosina.Importe = Decimal.Parse(txtPrecio.Text.Replace(".",","));

                        golosinaService.Modificar(golosina);

                        SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                        {
                            IdUsuario = this.Session.Usuario.Id,
                            IdCriticidad = (int)Enums.Criticidad.Baja,
                            Fecha = DateTime.Now,
                            Descripcion = "Golosina modificada. " + this.txtDescripcion.Text
                        };

                        bitacoraService.Registrar(reg);

                        MessageBox.Show("Golosina modificada con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string ValidarCampos()
        {
            if (txtStock.Text == "")
            {
                return "El campo Stock es requerido";
            }
            if (txtPrecio.Text == "")
            {
                return "El campo precio es requerido";
            }
            if (txtStockAlerta.Text == "")
            {
                return "El campo cantidad stock alerta es requerido";
            }

            return string.Empty;
        }
    }
}
