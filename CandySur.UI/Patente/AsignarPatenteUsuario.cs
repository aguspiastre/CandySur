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

namespace CandySur.UI.Patente
{
    public partial class AsignarPatenteUsuario : Form
    {
        private SEG.Entity.SessionManager Session;
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Patente patenteService = new SEG.Service.Patente();
        SEG.Entity.Usuario usuario;

        public AsignarPatenteUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsignarPatenteUsuario_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();

            this.listPatenteAsignar.Items.AddRange
            (
                (
                    from p in patenteService.Listar()
                    select new ListViewItem(p.Nombre)
                ).ToArray()
            );
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNombreUsuario.Text))
                {
                    MessageBox.Show("El campo nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usuario = usuarioService.Consultar(txtNombreUsuario.Text);

                    this.listPatenteDesasignar.Items.AddRange
                    (
                        (
                            from f in usuario.Permisos
                            where f.Compuesto == false
                            select new ListViewItem(f.Nombre)
                        ).ToArray()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = listPatenteAsignar.SelectedItems[0].Text;

                if (String.IsNullOrEmpty(patente))
                {
                    MessageBox.Show("Debe seleccionar una patente a asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    patenteService.Asignar(usuario, patente);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Descripcion = "Se asigno la patente " + patente + " al usuario " + usuario.NombreUsuario
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
                string patente = listPatenteDesasignar.SelectedItems[0].Text;

                if (String.IsNullOrEmpty(patente))
                {
                    MessageBox.Show("Debe seleccionar una patente a desasignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    patenteService.Desasignar(usuario, patente);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Descripcion = "Se desasigno la patente " + patente + " al usuario " + usuario.NombreUsuario
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
