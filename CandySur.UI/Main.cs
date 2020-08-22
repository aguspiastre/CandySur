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
    }
}
