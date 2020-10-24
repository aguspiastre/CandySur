using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI.Proveedor
{
    public partial class Listado_Proveedores : Form
    {
        private SEG.Service.SessionManager Session;
        CandySur.BLL.Proveedor proveedorService = new CandySur.BLL.Proveedor();

        public Listado_Proveedores()
        {
            InitializeComponent();
        }

        private void Listado_Proveedores_Load(object sender, EventArgs e)
        {
            try
            {
                //Session = SEG.Service.SessionManager.GetInstance();

                //this.validarPermisos(Session);

                //this.Traducir();
                //SEG.Service.IdiomaManager.Suscribir(this);

                List<CandySur.BE.Proveedor> proveedores = proveedorService.Listar();

                if (proveedores != null)
                {
                    this.dgvListadoProveedores.DataSource = proveedores;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
