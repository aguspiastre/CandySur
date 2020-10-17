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
    public partial class Gestionar : Form
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        CandySur.BLL.Descuento descuentoService = new CandySur.BLL.Descuento();
        private CandySur.BE.Descuento descuentoActivar;
        private CandySur.BE.Descuento descuentoDesactivar;

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

                this.dgvDesactivadas.DataSource = descuentoService.Listar().Where(d => d.Activo);

                this.dvgActivas.DataSource = descuentoService.Listar().Where(d => !d.Activo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.descuentoActivar == null)
                {
                    MessageBox.Show("Debe seleccionar un descuento a activar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    descuentoService.Activar(this.descuentoActivar);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Se activo el descuento " + descuentoActivar.Id
                    };

                    bitacoraService.Registrar(reg);

                    this.dvgActivas.DataSource = descuentoService.Listar().Where(d => d.Activo);

                    MessageBox.Show("Descuento activado de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDesactivadas_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvgActivas.SelectedRows)
            {
                descuentoActivar = (CandySur.BE.Descuento)row.DataBoundItem;
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.descuentoDesactivar == null)
                {
                    MessageBox.Show("Debe seleccionar un descuento a desactivar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    descuentoService.Activar(this.descuentoDesactivar);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Se desactivo el descuento " + descuentoDesactivar.Id
                    };

                    bitacoraService.Registrar(reg);

                    this.dgvDesactivadas.DataSource = descuentoService.Listar().Where(d => !d.Activo);

                    MessageBox.Show("Descuento desactivado de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgActivas_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvgActivas.SelectedRows)
            {
                this.descuentoDesactivar = (CandySur.BE.Descuento)row.DataBoundItem;
            }
        }
    }
}
