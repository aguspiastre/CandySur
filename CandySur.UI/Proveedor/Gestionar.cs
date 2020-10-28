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

namespace CandySur.UI.Proveedor
{
    public partial class Gestionar : Form
    {
        private SEG.Service.SessionManager Session;
        CandySur.BLL.Proveedor proveedorService = new CandySur.BLL.Proveedor();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        CandySur.BE.Proveedor proveedor;
        CandySur.BE.Golosina golosinaMail;
        public Gestionar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (proveedor == null)
                {
                    MessageBox.Show("Realizar la busqueda del proveedor previo a presionar modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    proveedor.Direccion = txtDireccion.Text;
                    proveedor.Telefono = txtTelefono.Text;
                    proveedor.Mail = txtEmail.Text;
                    proveedor.CodPostal = txtCodPostal.Text;

                    proveedorService.Modificar(proveedor);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Proveedor modificado. " + txtRazonSocial.Text
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Proveedor modificado con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (proveedor == null)
                {
                    MessageBox.Show("Realizar la busqueda del proveedor previo a presionar eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    proveedorService.Eliminar(proveedor.Cuit);

                    LimpiarCampos();

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Proveedor eliminado. " + proveedor.RazonSocial
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Proveedor eliminado con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCuit.Text))
                {
                    MessageBox.Show("El campo cuit es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    proveedor = proveedorService.ObtenerDetalle(txtCuit.Text);

                    txtCodPostal.Text = proveedor.CodPostal;
                    txtCuit.Text = proveedor.Cuit;
                    txtDireccion.Text = proveedor.Direccion;
                    txtEmail.Text = proveedor.Mail;
                    txtRazonSocial.Text = proveedor.RazonSocial;
                    txtTelefono.Text = proveedor.Telefono;

                    this.dgvProductosSuministrados.DataSource = proveedor.Golosinas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            proveedor = null;

            txtCodPostal.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCuit.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void dgvProductosSuministrados_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductosSuministrados.SelectedRows)
            {
                golosinaMail = (BE.Golosina)row.DataBoundItem;
            }
        }

        private void btnEnviarMailReposicion_Click(object sender, EventArgs e)
        {
            if(golosinaMail == null)
            {
                MessageBox.Show("Se debe seleccionar un producto de la grilla previo a enviar el mail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnviarMail mail = new EnviarMail(this.proveedor, this.golosinaMail);
                mail.Show();
            }
        }

        private void Gestionar_Load(object sender, EventArgs e)
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
    }
}
