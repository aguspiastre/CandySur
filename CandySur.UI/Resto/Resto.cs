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
    public partial class Resto : Form
    {
        private CandySur.BLL.Cobro cobroService;
        public Resto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            cobroService = new CandySur.BLL.Cobro();

            this.txtResto.Text = (cobroService.Calcular(Convert.ToDecimal(this.txtImporteTotal.Text), Convert.ToDecimal(this.txtMontoAbonado.Text))).ToString();
        }
    }
}
