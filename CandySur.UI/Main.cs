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

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var listarPatentes = new Patente.ListarPatentes();
            listarPatentes.MdiParent = this;
            listarPatentes.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var altaFamilia = new Familia.AltaFamilia();
            altaFamilia.MdiParent = this;
            altaFamilia.Show();
        }

        private void gestionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var gestionarFamilia = new Familia.GestionarFamilia();
            gestionarFamilia.MdiParent = this;
            gestionarFamilia.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listarFamilia = new Familia.ListarFamilias();
            listarFamilia.MdiParent = this;
            listarFamilia.Show();
        }

        private void asignacionAUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var asignarFamilia = new Familia.GestionarFamiliaUsuario();
            asignarFamilia.MdiParent = this;
            asignarFamilia.Show();
        }

        private void asignacionAUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var asignarPatenteUsuario = new Patente.GestionarPatenteUsuario();
            asignarPatenteUsuario.MdiParent = this;
            asignarPatenteUsuario.Show();
        }

        private void gestionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var gestionarContraseña = new Perfil.GestionarContraseña();
            gestionarContraseña.MdiParent = this;
            gestionarContraseña.Show();
        }

        private void asignacionAFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var asignarPatenteFamilia = new Familia.GestionarPatentesFamilia();
            asignarPatenteFamilia.MdiParent = this;
            asignarPatenteFamilia.Show();
        }
    }
}
