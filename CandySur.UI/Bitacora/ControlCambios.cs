using CandySur.SEG.Entity;
using CandySur.SEG.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI.Bitacora
{
    public partial class ControlCambios : Form, IIdiomaObserver
    {
        private CandySur.SEG.Service.SessionManager Session;
        private CandySur.SEG.Entity.Usuario Usuario;
        CandySur.SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        CandySur.SEG.Service.ControlCambios controlService = new SEG.Service.ControlCambios();
        public ControlCambios()
        {
            InitializeComponent();
        }

        private void ControlCambios_Load(object sender, EventArgs e)
        {
            try
            {
                Session = SEG.Service.SessionManager.GetInstance();

                validarPermisos(Session);

                Dictionary<string, string> comboUser = new Dictionary<string, string>();
                cmbUsuario.DisplayMember = "Value";
                cmbUsuario.ValueMember = "Key";

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);

                foreach (var item in usuarioService.Listar())
                {
                    comboUser.Add(item.Id.ToString(), item.NombreUsuario);
                }

                cmbUsuario.DataSource = new BindingSource(comboUser, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string value = ((KeyValuePair<string, string>)cmbUsuario.SelectedItem).Key;

                this.dataGridCambios.DataSource = controlService.Consultar(Convert.ToInt32(value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Usuario == null)
                {
                    MessageBox.Show("Seleccionar un registro antes de actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usuarioService.Modificar(Usuario, true);

                    this.dataGridCambios.DataSource = null;

                    MessageBox.Show("Usuario reestablecido con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridCambios_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridCambios.SelectedRows)
            {
                SEG.Entity.ControlCambios r = (SEG.Entity.ControlCambios)row.DataBoundItem;

                this.Usuario = new SEG.Entity.Usuario
                {
                    Id = r.Id_Usuario,
                    Apellido = r.Apellido,
                    Bloqueado = r.Bloqueado,
                    Contraseña = r.Contraseña,
                    Direccion = r.Direccion,
                    DNI = r.DNI,
                    Eliminado = r.Eliminado,
                    FechaNac = r.FechaNac,
                    Mail = r.Mail,
                    Nombre = r.Nombre,
                    NombreUsuario = r.NombreUsuario,
                    Reintentos = r.Reintentos,
                    Telefono = r.Telefono,
                };
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

        private void validarPermisos(SEG.Service.SessionManager Session)
        {
            bool contienePermisos = false;

            foreach (var item in Session.Usuario.Permisos)
            {
                if (item is SEG.Entity.Familia)
                {
                    SEG.Entity.Familia familia = (SEG.Entity.Familia)item;

                    if (familia.Permisos.Any(p => p.Nombre == "Buscar Control Cambios" || p.Nombre == "Actualizar Control Cambios"))
                        contienePermisos = true;

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
                case "Buscar Control Cambios":
                    this.btnBuscar.Visible = true;
                    contienePermisos = true;
                    break;
                case "Actualizar Control Cambios":
                    this.btnActualizar.Visible = true;
                    contienePermisos = true;
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
