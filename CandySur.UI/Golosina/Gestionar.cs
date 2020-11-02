using CandySur.SEG.Entity;
using CandySur.SEG.Service;
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
    public partial class Gestionar : Form , IIdiomaObserver
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

                    //Alerta stock
                    if(golosina.Stock == 0)
                    {
                        this.lblStockActual.Text = "Sin stock.";
                        this.lblStockActual.ForeColor = Color.Red;
                    }
                    else if(golosina.Stock <= golosina.AlertaStock)
                    {
                        this.lblStockActual.Text = "Stock reducido.";
                        this.lblStockActual.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        this.lblStockActual.Text = "En stock.";
                        this.lblStockActual.ForeColor = Color.Green;
                    }

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

        private void Gestionar_Load(object sender, EventArgs e)
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                case "Modificar Golosina":
                    this.btnModificar.Visible = true;
                    contienePermisos = true;
                    break;
                case "Eliminar Golosina":
                    this.btnEliminar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }
    }
}
