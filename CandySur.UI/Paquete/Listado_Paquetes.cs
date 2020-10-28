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
    public partial class Listado_Paquetes : Form
    {
        private SEG.Service.SessionManager Session;
        CandySur.BLL.Paquete paqueteService = new BLL.Paquete();

        public Listado_Paquetes()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listado_Paquetes_Load(object sender, EventArgs e)
        {
            try
            {
                Session = SEG.Service.SessionManager.GetInstance();

                //this.validarPermisos(Session);

                //this.Traducir();
                //SEG.Service.IdiomaManager.Suscribir(this);

                this.dgvPaquetes.DataSource = paqueteService.Listar().Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Stock = x.Stock }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }
    }
}
