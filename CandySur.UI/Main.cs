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

namespace CandySur.UI
{
    public partial class Main : Form
    {
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        SEG.Entity.Usuario usuario;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var consultarBitacora = new Bitacora.ConsultarBitacora();
            consultarBitacora.MdiParent = this;
            consultarBitacora.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var backupRestore = new Backup_Restore.BackupRestore();
            backupRestore.MdiParent = this;
            backupRestore.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var altaUsuario = new Usuario.AltaUsuario();
            altaUsuario.MdiParent = this;
            altaUsuario.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                {
                    IdUsuario = usuario.Id,
                    IdCriticidad = (int)Enums.Criticidad.Baja,
                    Fecha = DateTime.Now,
                    Descripcion = "Cierre de sesión"
                };

                bitacoraService.Registrar(reg);

                this.Close();
            }
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestionarUsuario = new Usuario.GestionarUsuario();
            gestionarUsuario.MdiParent = this;
            gestionarUsuario.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listarUsuarios = new Usuario.ListarUsuarios();
            listarUsuarios.MdiParent = this;
            listarUsuarios.Show();
        }
    }
}
