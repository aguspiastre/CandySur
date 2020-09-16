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
    public partial class GestionarPatentesFamilia : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        private SEG.Entity.Familia familia;
        private List<SEG.Entity.Patente> patentes;
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Service.Familia familiaService = new SEG.Service.Familia();
        SEG.Service.Patente patenteService = new SEG.Service.Patente();

        public GestionarPatentesFamilia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsignarPatentesFamilia_Load(object sender, EventArgs e)
        {
            patentes = patenteService.Listar();
            Session = SEG.Service.SessionManager.GetInstance();

            this.Traducir();
            SEG.Service.IdiomaManager.Suscribir(this);

            this.cmbFamilia.DataSource = familiaService.Listar();
            this.cmbFamilia.DisplayMember = "Nombre";
            this.cmbFamilia.ValueMember = "Id";

            this.listPatentesAsignar.Items.AddRange
            (
                (
                    from f in patentes
                    select new ListViewItem(f.Nombre)
                ).ToArray()
            );
        }

        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            familia = (SEG.Entity.Familia)this.cmbFamilia.SelectedItem;
            this.listPatentesDesasignar.Items.Clear();

            if (familia.Permisos != null)
            {
                this.listPatentesDesasignar.Items.AddRange
                (
                    (
                        from f in familia.Permisos
                        select new ListViewItem(f.Nombre)
                    ).ToArray()
                );
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listPatentesAsignar.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una patente a asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nombrePatente = listPatentesAsignar.SelectedItems[0].Text;

                    SEG.Entity.Patente patente = patentes.FirstOrDefault(p => !p.Compuesto && p.Nombre == nombrePatente) as SEG.Entity.Patente;

                    familiaService.Asignar(familia, patente);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Se asigno la patente " + patente.Nombre + " a la familia " + familia.Nombre
                    };

                    bitacoraService.Registrar(reg);

                    //Agrego la familia a la lista para desasignar
                    this.listPatentesDesasignar.Items.Add(patente.Nombre);
                    familia.Permisos.Add(patente);

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
                if (listPatentesDesasignar.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una patente a desasignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nombrePatente = listPatentesDesasignar.SelectedItems[0].Text;

                    SEG.Entity.Patente patente = familia.Permisos.FirstOrDefault(p => !p.Compuesto && p.Nombre == nombrePatente) as SEG.Entity.Patente;

                    familiaService.Desasignar(familia, patente);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Baja,
                        Fecha = DateTime.Now,
                        Descripcion = "Se desasigno la patente " + patente.Nombre + " a la familia " + familia.Nombre
                    };

                    bitacoraService.Registrar(reg);

                    //Elimino a la familia de la lista para desasignar.
                    this.listPatentesDesasignar.Items.RemoveAt(listPatentesDesasignar.SelectedIndices[0]);
                    familia.Permisos.Remove(patente);

                    MessageBox.Show("Patente desasignada de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void GestionarPatentesFamilia_FormClosing(object sender, FormClosingEventArgs e)
        {
            SEG.Service.IdiomaManager.Desuscribir(this);
        }
    }
}
