using CandySur.BE;
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
    public partial class Gestionar_Venta : Form, IIdiomaObserver
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

                    this.lblImporteTotal.Text = "$ ";

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gestionar_Venta_Load(object sender, EventArgs e)
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
                case "Eliminar Venta":
                    this.btnEliminar.Visible = true;
                    this.btnAceptar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }
    }
}
