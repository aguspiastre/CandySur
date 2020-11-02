using CandySur.SEG.Entity;
using CandySur.SEG.Service;
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
    public partial class EnviarMail : Form, IIdiomaObserver
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

                this.validarPermisos(Session);

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);

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
                case "Enviar Mail Reposicion":
                    this.btnEnviar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }
    }
}
