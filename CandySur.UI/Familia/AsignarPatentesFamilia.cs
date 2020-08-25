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
    public partial class AsignarPatentesFamilia : Form
    {
        private SEG.Entity.SessionManager Session;
        private SEG.Entity.Familia familia;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Familia familiaService = new SEG.Service.Familia();
        SEG.Service.Patente patenteService = new SEG.Service.Patente();

        public AsignarPatentesFamilia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsignarPatentesFamilia_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();

            this.cmbFamilia.DataSource = familiaService.Listar();

            this.listPatentesAsignar.Items.AddRange
            (
                (
                    from f in patenteService.Listar()
                    select new ListViewItem(f.Nombre)
                ).ToArray()
            );
        }

        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            familia = (SEG.Entity.Familia)this.cmbFamilia.SelectedItem;

            this.listPatentesDesasignar.Items.AddRange
            (
                (
                    from f in familia.Permisos
                    select new ListViewItem(f.Nombre)
                ).ToArray()
            );
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombrePatente = listPatentesAsignar.SelectedItems[0].Text;

                if (String.IsNullOrEmpty(nombrePatente))
                {
                    MessageBox.Show("Debe seleccionar una patente a asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SEG.Entity.Patente patente = familia.Permisos.FirstOrDefault(p => p.Compuesto && p.Nombre == nombrePatente) as SEG.Entity.Patente;

                    familiaService.Asignar(familia, patente);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Descripcion = "Se asigno la patente " + patente.Nombre + " a la familia " + familia.Nombre
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Patente asignada de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombrePatente = listPatentesDesasignar.SelectedItems[0].Text;

                if (String.IsNullOrEmpty(nombrePatente))
                {
                    MessageBox.Show("Debe seleccionar una patente a desasignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SEG.Entity.Patente patente = familia.Permisos.FirstOrDefault(p => p.Compuesto && p.Nombre == nombrePatente) as SEG.Entity.Patente;

                    familiaService.Desasignar(familia, patente);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Descripcion = "Se desasigno la patente " + patente.Nombre + " a la familia " + familia.Nombre
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Patente desasignada de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
