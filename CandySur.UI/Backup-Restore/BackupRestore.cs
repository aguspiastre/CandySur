using CandySur.SEG.Service;
using CandySur.SEG.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CandySur.SEG.Util.Enums;
using CandySur.SEG.Entity;
using System.Reflection;

namespace CandySur.UI.Backup_Restore
{
    public partial class BackupRestore : Form, IIdiomaObserver
    {
        private CandySur.SEG.Service.SessionManager Session;
        private const string RUTA_DESTINO = @"C:\CandySur\Backups";
        SEG.Service.DataBase databaseService = new SEG.Service.DataBase();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();

        public BackupRestore()
        {
            InitializeComponent();
        }

        private void BackupRestore_Load(object sender, EventArgs e)
        {
            try
            {
                Session = SEG.Service.SessionManager.GetInstance();

                validarPermisos(Session);

                this.Traducir();
                SEG.Service.IdiomaManager.Suscribir(this);

                //Generacion de carpeta en caso de que no exista.
                if (!Directory.Exists(RUTA_DESTINO))
                {
                    Directory.CreateDirectory(RUTA_DESTINO);
                }

                this.ListarBackups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string fullUri = RUTA_DESTINO + @"\" + cmbBackup.SelectedItem.ToString();

                databaseService.RealizarRestore("CandySur", fullUri);

                SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                {
                    IdUsuario = Session.Usuario.Id,
                    IdCriticidad = (int)Enums.Criticidad.Alta,
                    Fecha = DateTime.Now,
                    Descripcion = "Restore realizado con exito"
                };

                bitacoraService.Registrar(reg);

                MessageBox.Show("Se ha realizado el restore de la base de datos de forma correcta", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string fullUri = RUTA_DESTINO + "\\CandySur" + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

                databaseService.NuevoBackup("CandySur", fullUri);

                this.ListarBackups();

                SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                {
                    IdUsuario = this.Session.Usuario.Id,
                    IdCriticidad = (int)Enums.Criticidad.Alta,
                    Fecha = DateTime.Now,
                    Descripcion = "Backup guardado con exito"
                };

                bitacoraService.Registrar(reg);

                MessageBox.Show("Se ha guardo el backup de la base de datos de forma correcta", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarBackups()
        {
            DirectoryInfo d = new DirectoryInfo(RUTA_DESTINO);
            FileInfo[] Files = d.GetFiles("*CandySur*");

            cmbBackup.Items.Clear();

            foreach (FileInfo file in Files) { cmbBackup.Items.Add(file); }
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

        private void BackupRestore_FormClosing(object sender, FormClosingEventArgs e)
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
                case "Realizar Restore":
                    this.btnRestore.Visible = true;
                    contienePermisos = true;
                    break;
                case "Nuevo Backup":
                    this.btnNuevoBackup.Visible = true;
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
