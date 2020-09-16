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
using CandySur.SEG.Entity;

namespace CandySur.UI.Familia
{
    public partial class AltaFamilia : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Familia familiaService = new SEG.Service.Familia();
        public AltaFamilia()
        {
            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            Session = SEG.Service.SessionManager.GetInstance();

            this.Traducir();
            SEG.Service.IdiomaManager.Suscribir(this);
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
                    SEG.Entity.Familia familia = new SEG.Entity.Familia
                    {
                        Compuesto = true,
                        Descripcion = txtDescripcion.Text,
                        Nombre = txtNombre.Text,
                        Eliminado = false
                    };

                    familiaService.Alta(familia);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Familia dada de alta. " + txtNombre.Text
                    };

                    bitacoraService.Registrar(reg);

                    this.LimpiarCampos();

                    MessageBox.Show("Familia dada de alta correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidarCampos()
        {
            if (txtNombre.Text == "")
            {
                return "El campo nombre es requerido";
            }
            if (txtDescripcion.Text == "")
            {
                return "El campo descripcion es requerido";
            }

            return string.Empty;
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
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

        private void AltaFamilia_FormClosing(object sender, FormClosingEventArgs e)
        {
            SEG.Service.IdiomaManager.Desuscribir(this);
        }
    }
}
