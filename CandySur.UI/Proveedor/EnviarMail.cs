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
    public partial class EnviarMail : Form
    {
        private BE.Proveedor proveedor;
        private BE.Golosina golosina;
        private SEG.Service.SessionManager Session;

        public EnviarMail(BE.Proveedor proveedor, BE.Golosina golosina)
        {
            InitializeComponent();

            this.proveedor = proveedor;
            this.golosina = golosina;

            // Mapeo los textbox.
            this.txtCodProducto.Text = golosina.Id.ToString();
            this.txtCuit.Text = proveedor.Cuit;
            this.txtDescripcionProd.Text = golosina.Descripcion;
            this.txtEmail.Text = proveedor.Mail;
            this.txtRazonSocial.Text = proveedor.RazonSocial;
            this.txtStockActual.Text = golosina.Stock.ToString();
            this.txtTelefono.Text = proveedor.Telefono;
        }

        private void EnviarMail_Load(object sender, EventArgs e)
        {
            try
            {
                Session = SEG.Service.SessionManager.GetInstance();

                //this.validarPermisos(Session);

                //this.Traducir();
                //SEG.Service.IdiomaManager.Suscribir(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string validarCampos = this.ValidarCampos();

                if (!String.IsNullOrEmpty(validarCampos))
                {
                    MessageBox.Show(validarCampos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var msg = "Estimados, por favor, solicitamos reposicion del siguiente producto: " + golosina.Descripcion + " por una cantidad de: " + txtCantidadAReponer.Text + ". Saludos!";

                    UTIL.Mail.EnviarMail(this.proveedor.Mail, "Reposicion de producto.", msg);

                    this.LimpiarCampos();

                    MessageBox.Show("Email enviado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarCampos()
        {
            if (txtCantidadAReponer.Text == "")
            {
                return "El campo cantidad a reponer es requerido";
            }

            return string.Empty;
        }

        private void LimpiarCampos()
        {
            this.txtCantidadAReponer.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
