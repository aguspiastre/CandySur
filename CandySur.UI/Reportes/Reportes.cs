using CandySur.SEG.Entity;
using CandySur.SEG.Service;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI.Reportes
{
    public partial class Reportes : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        private string fileName;
        private string titulo;
        private string paragraph;

        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                //Session = SEG.Service.SessionManager.GetInstance();

                //this.validarPermisos(Session);

                //this.Traducir();
                //SEG.Service.IdiomaManager.Suscribir(this);

                this.rdbVentas.Checked = true;
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
                    this.fileName = $"ReporteVentas_{DateTime.Now.ToString("yyyy-MM-dd")}.pdf";
                    this.titulo = "Reporte de Ventas.";
                    this.paragraph = $"Reporte de ventas entre las fechas {this.dtpFechaDsd.Value.ToString("yyyy-MM-dd")} y {this.dtpFechaHst.Value.ToString("yyyy-MM-dd")}.";
                }
                else if (rbdPaquetes.Checked)
                {
                    this.dgReporte.DataSource = reportesService.GenerarReportesPaquetes(this.dtpFechaDsd.Value, this.dtpFechaHst.Value).Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Cantidad = x.Stock }).ToList();
                    this.fileName = $"ReportePaquetes_{DateTime.Now.ToString("yyyy-MM-dd")}.pdf";
                    this.titulo = "Reporte de Paquetes.";
                    this.paragraph = $"Reporte de paquetes mas comercializados entre las fechas {this.dtpFechaDsd.Value.ToString("yyyy-MM-dd")} y {this.dtpFechaHst.Value.ToString("yyyy-MM-dd")}.";
                }
                else if (rbdGolosinas.Checked)
                {
                    this.dgReporte.DataSource = reportesService.GenerarReportesGolosinas(this.dtpFechaDsd.Value, this.dtpFechaHst.Value).Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Cantidad = x.Stock }).ToList();
                    this.fileName = $"ReporteGolosinas_{DateTime.Now.ToString("yyyy-MM-dd")}.pdf";
                    this.titulo = "Reporte de Golosinas.";
                    this.paragraph = $"Reporte de golosinas mas comercializadas entre las fechas {this.dtpFechaDsd.Value.ToString("yyyy-MM-dd")} y {this.dtpFechaHst.Value.ToString("yyyy-MM-dd")}.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgReporte.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = this.fileName;
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            File.Delete(sfd.FileName);
                        }
                        if (!fileError)
                        {
                            PdfPTable pdfTable = new PdfPTable(dgReporte.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgReporte.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgReporte.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);

                                pdfDoc.Open();

                                //Titulo y parrafo.
                                iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 26);
                                titleFont.IsUnderlined();

                                iTextSharp.text.Font regularFont = FontFactory.GetFont("Arial", 15);

                                Paragraph title = new Paragraph(this.titulo, titleFont);
                                title.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(title);

                                pdfDoc.Add(new Chunk("\n"));

                                Paragraph text = new Paragraph(this.paragraph, regularFont);
                                pdfDoc.Add(text);

                                pdfDoc.Add(new Chunk("\n"));

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Exportacion realizada con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    throw new Exception("No hay registros para exportar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
