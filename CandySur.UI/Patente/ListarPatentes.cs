using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI.Patente
{
    public partial class ListarPatentes : Form
    {
        private SEG.Entity.SessionManager Session;
        SEG.Service.Patente patenteService = new SEG.Service.Patente();

        public ListarPatentes()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarPatentes_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();

            this.dgvPatentes.DataSource = patenteService.Listar().Select(x => new { Nombre = x.Nombre, Descripcion = x.Descripcion }).ToList();
        }
    }
}
