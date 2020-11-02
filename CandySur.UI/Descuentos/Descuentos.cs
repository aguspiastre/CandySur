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
    public partial class Descuentos : Form, IIdiomaObserver
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
                Session = SEG.Service.SessionManager.GetInstance();

                this.validarPermisos(Session);

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);

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
                case "Configurar Descuento":
                    this.btnFinalizar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }
    }
}
