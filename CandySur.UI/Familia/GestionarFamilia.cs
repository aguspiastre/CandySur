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
    public partial class GestionarFamilia : Form
    {
        private SEG.Entity.SessionManager Session;
        private List<SEG.Entity.Permiso> Familias;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Familia familiaService = new SEG.Service.Familia();

        public GestionarFamilia()
        {
            InitializeComponent();
        }

        private void GestionarFamilia_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();
            Familias = familiaService.Listar();
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
                    SEG.Entity.Familia familia = this.Familias.FirstOrDefault(f => f.Nombre == this.cmbFamilia.SelectedText) as SEG.Entity.Familia;

                    familiaService.Eliminar(familia);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = this.Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Familia eliminada. " + this.cmbFamilia.SelectedText
                    };

                    bitacoraService.Registrar(reg);

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
                    SEG.Entity.Familia familia = this.Familias.FirstOrDefault(f => f.Nombre == this.cmbFamilia.SelectedText) as SEG.Entity.Familia;

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
            SEG.Entity.Familia familia = this.Familias.FirstOrDefault(f => f.Nombre == this.cmbFamilia.SelectedText) as SEG.Entity.Familia;
            txtNombre.Text = familia.Nombre;
            txtDescripcion.Text = familia.Descripcion;
        }
    }
}
