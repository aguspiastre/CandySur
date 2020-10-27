using CandySur.SEG.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI.Descuentos
{
    public partial class Descuentos : Form
    {
        private SEG.Service.SessionManager Session;
        private CandySur.BLL.Descuento descuentoService = new CandySur.BLL.Descuento();
        private SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        private List<CandySur.BE.Descuento> descuentos;

        public Descuentos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
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
                    CandySur.BE.Descuento d = new CandySur.BE.Descuento
                    {
                        Importe = Convert.ToDecimal(txtImporte.Text),
                        Porcentaje = Convert.ToDecimal(txtPorcentaje.Text.Replace(".", ",")),
                    };

                    descuentoService.Configurar(d);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Media,
                        Fecha = DateTime.Now,
                        Descripcion = "Descuento dado de alta."
                    };

                    bitacoraService.Registrar(reg);

                    this.descuentos = descuentoService.Listar();

                    this.dgvDescuentos.DataSource = this.descuentos.Select(x => new { Importe = x.Importe, Descuento = x.Porcentaje + "%", Activa = x.Activo }).ToList();

                    this.LimpiarCampos();

                    MessageBox.Show("Descuento dado de alta correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarCampos()
        {
            if (txtImporte.Text == "")
            {
                return "El campo importe es requerido";
            }
            if (txtPorcentaje.Text == "")
            {
                return "El campo porcenaje es requerido";
            }

            if(Convert.ToDecimal(txtPorcentaje.Text) >= 100)
            {
                return "El campo porcenaje no puede ser mayor o igual a 100.";
            }

            return string.Empty;
        }

        private void Descuentos_Load(object sender, EventArgs e)
        {
            Session = SEG.Service.SessionManager.GetInstance();
            try
            {
                //Session = SEG.Service.SessionManager.GetInstance();

                //this.validarPermisos(Session);

                //this.Traducir();
                //SEG.Service.IdiomaManager.Suscribir(this);
                this.descuentos = descuentoService.Listar();

                this.dgvDescuentos.DataSource = this.descuentos.Select(x => new { Importe = x.Importe, Descuento = x.Porcentaje + "%", Activa = x.Activo }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void LimpiarCampos()
        {
            txtImporte.Text = string.Empty;
            txtPorcentaje.Text = string.Empty;
        }
    }
}
