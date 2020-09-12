using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI.Familia
{
    public partial class ListarFamilias : Form
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Familia familiaService = new SEG.Service.Familia();
        public ListarFamilias()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarFamilias_Load(object sender, EventArgs e)
        {
            Session = SEG.Service.SessionManager.GetInstance();

            this.dgvFamilias.DataSource = familiaService.Listar().Select(x => new { Nombre = x.Nombre, Descripcion = x.Descripcion }).ToList();
        }
    }
}
