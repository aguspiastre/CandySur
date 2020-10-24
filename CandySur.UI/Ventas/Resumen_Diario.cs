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
    public partial class Resumen_Diario : Form
    {
        private SEG.Service.SessionManager Session;
        CandySur.BLL.Venta ventaService = new CandySur.BLL.Venta();

        public Resumen_Diario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resumen_Diario_Load(object sender, EventArgs e)
        {
            try
            {
                //Session = SEG.Service.SessionManager.GetInstance();

                //this.validarPermisos(Session);

                //this.Traducir();
                //SEG.Service.IdiomaManager.Suscribir(this);

                List<CandySur.BE.Venta> ventas = ventaService.ListarDiarias();

                if (ventas != null && ventas.Count > 0)
                {
                    this.dvgVentasDiarias.DataSource = ventas.Select(x => new { Codigo = x.Id, Importe = x.Importe, Fecha = x.Fecha }).ToList();

                    VisualizarImporteTotal(ventas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void VisualizarImporteTotal(List<BE.Venta> ventas)
        {
            decimal importeTotal = 0;

            foreach (var item in ventas)
            {
                importeTotal += item.Importe;
            }

            this.lblTotalComercializado.Text = "$ " + importeTotal;
        }
    }
}
