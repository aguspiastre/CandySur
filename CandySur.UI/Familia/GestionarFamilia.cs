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

namespace CandySur.UI.Familia
{
    public partial class GestionarFamilia : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        private List<SEG.Entity.Familia> Familias;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Familia familiaService = new SEG.Service.Familia();

        public GestionarFamilia()
        {
            InitializeComponent();
        }

        private void GestionarFamilia_Load(object sender, EventArgs e)
        {
            try
            {
                Session = SEG.Service.SessionManager.GetInstance();

                this.validarPermisos(Session);

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);

                Familias = familiaService.Listar();

                cmbFamilia.DataSource = Familias;
                cmbFamilia.DisplayMember = "Nombre";
                cmbFamilia.ValueMember = "Id";
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
                string validarCampos = this.ValidarCampos();

                if (!String.IsNullOrEmpty(validarCampos))
                {
                    MessageBox.Show(validarCampos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SEG.Entity.Familia familia = (SEG.Entity.Familia)this.cmbFamilia.SelectedItem as SEG.Entity.Familia;

                    familiaService.Eliminar(familia);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Familia eliminada. " + this.cmbFamilia.SelectedText
                    };

                    bitacoraService.Registrar(reg);

                    LimpiarCampos();

                    MessageBox.Show("Familia eliminada correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                    SEG.Entity.Familia familia = (SEG.Entity.Familia)this.cmbFamilia.SelectedItem as SEG.Entity.Familia;

                    familia.Descripcion = txtDescripcion.Text;

                    familiaService.Modificar(familia);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Familia modificada. " + txtNombre.Text
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Familia modificada correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                return "Seleccionar una familia previo a modificar/eliminar.";
            }
            if (txtDescripcion.Text == "")
            {
                return "El campo descripcion es requerido";
            }

            return string.Empty;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            SEG.Entity.Familia familia = (SEG.Entity.Familia)this.cmbFamilia.SelectedItem as SEG.Entity.Familia;

            if(familia != null)
            {
                txtNombre.Text = familia.Nombre;
                txtDescripcion.Text = familia.Descripcion;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;

            Familias = familiaService.Listar();
            cmbFamilia.DataSource = Familias;

            cmbFamilia.DisplayMember = "Nombre";
            cmbFamilia.ValueMember = "Id";
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

        private void GestionarFamilia_FormClosing(object sender, FormClosingEventArgs e)
        {
            SEG.Service.IdiomaManager.Desuscribir(this);
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
                case "Modificar Familia":
                    this.btnModificar.Visible = true;
                    contienePermisos = true;
                    break;
                case "Eliminar Familia":
                    this.btnEliminar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }
    }
}
