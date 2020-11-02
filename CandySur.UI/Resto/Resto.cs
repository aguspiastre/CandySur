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

namespace CandySur.UI.Resto
{
    public partial class Resto : Form, IIdiomaObserver
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

                    this.txtResto.Text = (cobroService.Calcular(Convert.ToDecimal(this.txtImporteTotal.Text.Replace(".", ",")), Convert.ToDecimal(this.txtMontoAbonado.Text.Replace(".", ",")))).ToString();
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
                Session = SEG.Service.SessionManager.GetInstance();

                this.validarPermisos(Session);

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);

                this.txtSubTotal.Text = this.venta.Importe.ToString();

                BLL.Descuento descuentosService = new BLL.Descuento();

                List<CandySur.BE.Descuento> descuentos = descuentosService.Listar();

                BE.Descuento descuento = descuentosService.CalcularDescuentos(descuentos, this.venta.Importe);

                if (descuento != null)
                {
                    this.txtDescuentoAplicado.Text = ((descuento.Porcentaje * this.venta.Importe) / 100).ToString();
                    this.venta.Importe -= Convert.ToDecimal(this.txtDescuentoAplicado.Text);
                    this.txtImporteTotal.Text = this.venta.Importe.ToString();

                } else
                {
                    this.txtDescuentoAplicado.Text = "0";
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
                case "Realizar Restore":
                    this.btnCalcular.Visible = true;
                    contienePermisos = true;
                    break;
                case "Nuevo Backup":
                    this.btnFinalizar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }

    }
}
