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

namespace CandySur.UI.Paquete
{
    public partial class Gestionar : Form
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        BLL.Paquete paqueteService = new BLL.Paquete();
        BE.Paquete paqueteSeleccionado;

        public Gestionar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gestionar_Load(object sender, EventArgs e)
        {
            try
            {
                //Session = SEG.Service.SessionManager.GetInstance();

                //this.validarPermisos(Session);

                //this.Traducir();
                //SEG.Service.IdiomaManager.Suscribir(this);

                cmbPaquetes.DataSource = paqueteService.Listar();
                cmbPaquetes.DisplayMember = "Descripcion";
                cmbPaquetes.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void cmbPaquetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idPaquete = Convert.ToInt32(cmbPaquetes.SelectedValue);

                BE.Paquete paqueteSeleccionado = paqueteService.ObtenerDetalle(idPaquete);

                this.txtDescripcion.Text = paqueteSeleccionado.Descripcion;
                this.txtPrecio.Text = paqueteSeleccionado.Importe.ToString();
                this.txtStock.Text = paqueteSeleccionado.Stock.ToString();

                this.dgvGolosinas.DataSource = paqueteSeleccionado.Golosinas.Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Stock = x.Stock }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (paqueteSeleccionado == null)
                {
                    MessageBox.Show("Se debe seleccionar un paquete previo a presionar eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    paqueteService.Eliminar(paqueteSeleccionado);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Paquete eliminado. " + this.paqueteSeleccionado.Descripcion
                    };

                    bitacoraService.Registrar(reg);

                    cmbPaquetes.DataSource = paqueteService.Listar();

                    LimpiarCampos();

                    MessageBox.Show("Paquete eliminado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            this.txtDescripcion.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
            this.txtStock.Text = string.Empty;

            this.dgvGolosinas.DataSource = null;
        }
    }
}
