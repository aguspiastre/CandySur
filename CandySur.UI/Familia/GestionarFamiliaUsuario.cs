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
    public partial class GestionarFamiliaUsuario : Form
    {
        private SEG.Entity.SessionManager Session;
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Familia familiaService = new SEG.Service.Familia();
        SEG.Entity.Usuario usuario;
        public GestionarFamiliaUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    if (usuario == null)
                    {
                        MessageBox.Show("No se encontro al usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (usuario.Permisos != null && usuario.Permisos.Any())
                        {
                            this.listFamiliaDesasignar.Items.AddRange
                            (
                                (
                                    from f in usuario.Permisos
                                    where f.Compuesto == true
                                    select new ListViewItem(f.Nombre)
                                ).ToArray()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsignarFamiliaUsuario_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();

            this.listFamiliasAsignar.Items.AddRange
            (
                (
                    from f in familiaService.Listar()
                    select new ListViewItem(f.Nombre)
                ).ToArray()
            );
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario == null)
                {
                    MessageBox.Show("Debe buscar un usuario previo a asignar una familia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (listFamiliasAsignar.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una familia a asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string familia = listFamiliasAsignar.SelectedItems[0].Text;

                    familiaService.Asignar(usuario, familia);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Se asigno la familia " + familia + " al usuario " + usuario.NombreUsuario
                    };

                    bitacoraService.Registrar(reg);

                    //Agrego la familia a la lista para desasignar
                    this.listFamiliaDesasignar.Items.Add(familia);

                    MessageBox.Show("Familia asignada de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (usuario == null)
                {
                    MessageBox.Show("Debe buscar un usuario previo a desasignar una familia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (listFamiliaDesasignar.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una familia a desasignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string familia = listFamiliasAsignar.SelectedItems[0].Text;

                    familiaService.Desasignar(usuario, familia);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Se desasigno la familia " + familia + " al usuario " + usuario.NombreUsuario
                    };

                    bitacoraService.Registrar(reg);

                    //Elimino a la familia de la lista para desasignar.
                    this.listFamiliaDesasignar.Items.RemoveAt(listFamiliasAsignar.SelectedIndices[0]);

                    MessageBox.Show("Familia desasignada de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
