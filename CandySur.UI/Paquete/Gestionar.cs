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
        BE.Paquete paquete;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (paquete == null)
                {
                    MessageBox.Show("Se debe buscar un paquete previo a presionar eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    paqueteService.Eliminar(paquete);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Paquete eliminado. " + this.paquete.Descripcion
                    };

                    bitacoraService.Registrar(reg);

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
            this.txtCodProducto.Text = string.Empty;

            this.paquete = null;
            this.dgvGolosinas.DataSource = null;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCodProducto.Text))
                {
                    MessageBox.Show("El campo codigo producto es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    paquete = paqueteService.ObtenerDetalle(int.Parse(txtCodProducto.Text));

                    txtDescripcion.Text = paquete.Descripcion;
                    txtPrecio.Text = paquete.Importe.ToString();
                    txtStock.Text = paquete.Stock.ToString();

                    this.dgvGolosinas.DataSource = paquete.Golosinas.Select(x => new { Codigo = x.Id, Descripcion = x.Descripcion, Importe = x.Importe, Cantidad = x.Cantidad }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
