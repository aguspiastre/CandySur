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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();

            this.rdbProducto.Checked = true;
            this.rdbPaquete.Checked = false;

            this.lblTipoProducto.Text = "Codigo Producto:";
            this.btnBuscarProducto.Visible = true;
            this.txtCodProducto.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdbProducto.Checked == false)
            {
                this.lblTipoProducto.Text = "Paquete:";
                this.btnBuscarProducto.Visible = false;
                this.txtCodProducto.Visible = false;
                this.cboPaquetes.Visible = true;
            }else
            {
                this.lblTipoProducto.Text = "Codigo Producto:";
                this.btnBuscarProducto.Visible = true;
                this.txtCodProducto.Visible = true;
                this.cboPaquetes.Visible = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
