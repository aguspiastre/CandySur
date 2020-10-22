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
    public partial class Listado_Golosinas : Form
    {
        private SEG.Service.SessionManager Session;
        CandySur.BLL.Golosina golosinaService = new BLL.Golosina();

        public Listado_Golosinas()
        {
            InitializeComponent();
        }

        private void Listado_Golosinas_Load(object sender, EventArgs e)
        {
            try
            {
                //Session = SEG.Service.SessionManager.GetInstance();

                //this.validarPermisos(Session);

                //this.Traducir();
                //SEG.Service.IdiomaManager.Suscribir(this);

                this.dgvListadoGolosinas.DataSource = golosinaService.Listar().Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Stock = x.Stock, Alerta_Stock = x.AlertaStock }).ToList();
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
    }
}
