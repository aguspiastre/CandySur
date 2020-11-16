using CandySur.SEG.Entity;
using CandySur.SEG.Request;
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

namespace CandySur.UI.Backup_Restore
{
    public partial class ReiniciarSistema : Form, IIdiomaObserver
    {
        private CandySur.SEG.Service.SessionManager Session;
        CandySur.SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        CandySur.SEG.Service.DigitoVerificador digitoverificadorService = new SEG.Service.DigitoVerificador();
        CandySur.SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

        public ReiniciarSistema()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Enums.Criticidad criticidad = (Enums.Criticidad)cmbCriticidad.SelectedItem;

                string value = ((KeyValuePair<string, string>)cmbUsuarios.SelectedItem).Key;

                ConsultarBitacoraRequest req = new ConsultarBitacoraRequest
                {
                    FechaDesde = this.dtpFechaDesde.Value.Date,
                    FechaHasta = this.dtpFechaHasta.Value.Date,
                    IdUsuario = Convert.ToInt32(value)
                };

                if ((int)criticidad != 0)
                {
                    req.IdCriticidad = (int)criticidad;
                }

                List<CandySur.SEG.Entity.Bitacora> list = bitacoraService.Consultar(req);

                this.dtgBitacora.DataSource = list.Select(x => new { Usuario = x.Usuario, Evento = x.Descripcion, Fecha = x.Fecha, Criticidad = x.Criticidad }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReestablecerSistema_Load(object sender, EventArgs e)
        {
            try
            {
                Session = SEG.Service.SessionManager.GetInstance();

                this.validarPermisos(Session);

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);

                cmbCriticidad.DataSource = Enum.GetValues(typeof(CandySur.SEG.Util.Enums.Criticidad));

                Dictionary<string, string> comboUser = new Dictionary<string, string>();
                cmbUsuarios.DisplayMember = "Value";
                cmbUsuarios.ValueMember = "Key";
                comboUser.Add("0", "");

                foreach (var item in usuarioService.Listar())
                {
                    comboUser.Add(item.Id.ToString(), item.NombreUsuario);
                }

                cmbUsuarios.DataSource = new BindingSource(comboUser, null);
                cmbUsuarios.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void btnRealizarRestore_Click(object sender, EventArgs e)
        {
            var formRealizarBackup = new Backup_Restore.BackupRestore();
            formRealizarBackup.Show();
        }

        private void btnRecalcularDV_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = digitoverificadorService.RecalcularDVV();

                if (!result)
                    throw new Exception("No se pudo recalcular los digitos verificadores.");

                MessageBox.Show("Digitos verificadores recalculados de manera correcta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarSesuinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "¿Desea cerrar sesión?";
            string tittle = "Cerrar Sesion";

            var idiomaManager = SEG.Service.IdiomaManager.GetInstance();

            if (idiomaManager.Idioma != null && !idiomaManager.Idioma.Principal)
            {
                msg = "¿Are you sure that you want to sign off?";
                tittle = "Sign Off";
            }

            DialogResult result = MessageBox.Show(msg, tittle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                {
                    IdUsuario = Session.Usuario.Id,
                    IdCriticidad = (int)Enums.Criticidad.Baja,
                    Fecha = DateTime.Now,
                    Descripcion = "Cierre de sesión"
                };

                bitacoraService.Registrar(reg);

                SEG.Service.SessionManager.LogOut();

                this.Close();
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

                    if (familia.Permisos.Any(p => p.Nombre == "Realizar Restore" || p.Nombre == "Nuevo Backup"))
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
                case "Realizar Restore":
                    this.btnRealizarRestore.Visible = true;
                    contienePermisos = true;
                    break;

                case "Recalcular DV":
                    this.btnRecalcularDV.Visible = true;
                    contienePermisos = true;
                    break;

                case "Buscar Bitacora":
                    this.btnBuscar.Visible = true;
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
