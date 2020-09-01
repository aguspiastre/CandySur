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

namespace CandySur.UI.Backup_Restore
{
    public partial class BackupRestore : Form
    {
        private CandySur.SEG.Entity.SessionManager Session;
        private const string RUTA_DESTINO = "C:\\Program Files (x86)\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Backup";
        SEG.Service.DataBase databaseService = new SEG.Service.DataBase();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();

        public BackupRestore()
        {
            InitializeComponent();
        }

        private void BackupRestore_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();

            this.CargarBackups();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                databaseService.RealizarRestore("CandySur", cmbBackup.SelectedItem.ToString());

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

                this.CargarBackups();

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

        private void CargarBackups()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\\Program Files (x86)\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Backup");
            FileInfo[] Files = d.GetFiles("*CandySur*");

            cmbBackup.Items.Clear();

            foreach (FileInfo file in Files) { cmbBackup.Items.Add(file); }
        }
    }
}
