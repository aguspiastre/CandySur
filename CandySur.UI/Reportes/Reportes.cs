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

namespace CandySur.UI.Reportes
{
    public partial class Reportes : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
    
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
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
                case "Reportes":
                    this.btnBuscar.Visible = true;
                    this.btnExportarPDF.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Reportes reportesService = new BLL.Reportes();

                if (rdbVentas.Checked)
                {
                    this.dgReporte.DataSource = reportesService.GenerarReportesVentas(this.dtpFechaDsd.Value, this.dtpFechaHst.Value).Select(x => new { Codigo = x.Id, Importe = x.Importe, Fecha = x.Fecha }).ToList();
                }
                else if(rbdPaquetes.Checked)
                {
                    this.dgReporte.DataSource = reportesService.GenerarReportesPaquetes(this.dtpFechaDsd.Value, this.dtpFechaHst.Value).Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Cantidad = x.Stock }).ToList();
                }
                else if(rbdGolosinas.Checked)
                {
                    this.dgReporte.DataSource = reportesService.GenerarReportesGolosinas(this.dtpFechaDsd.Value, this.dtpFechaHst.Value).Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Cantidad = x.Stock }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
