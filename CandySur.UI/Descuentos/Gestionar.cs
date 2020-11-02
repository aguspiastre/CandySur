using CandySur.SEG.Entity;
using CandySur.SEG.Service;
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
    public partial class Gestionar : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        CandySur.BLL.Descuento descuentoService = new CandySur.BLL.Descuento();

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
                Session = SEG.Service.SessionManager.GetInstance();

                this.validarPermisos(Session);

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);

                CargarDescuentos();
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
                if (this.dvgPromocionesDesactivadas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un descuento a activar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BE.Descuento descuento = dvgPromocionesDesactivadas.SelectedRows[0]?.DataBoundItem as BE.Descuento;

                    descuentoService.Activar(descuento);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Se activo el descuento " + descuento.Id
                    };

                    bitacoraService.Registrar(reg);

                    this.CargarDescuentos();

                    MessageBox.Show("Descuento activado de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dvgPromocionesActivas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un descuento a desactivar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BE.Descuento descuento = dvgPromocionesActivas.SelectedRows[0]?.DataBoundItem as BE.Descuento;

                    descuentoService.Desactivar(descuento);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Se desactivo el descuento " + descuento.Id
                    };

                    bitacoraService.Registrar(reg);

                    CargarDescuentos();

                    MessageBox.Show("Descuento desactivado de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDescuentos()
        {
            List<BE.Descuento> descuentos = descuentoService.Listar();

            this.dvgPromocionesDesactivadas.DataSource = descuentos.Where(x => x.Activo == false).ToList();

            this.dvgPromocionesActivas.DataSource = descuentos.Where(x => x.Activo == true).ToList();
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
                case "Gestionar Descuento":
                    this.btnActivar.Visible = true;
                    this.btnDesactivar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }
    }
}
