using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandySur.UI.Usuario
{
    public partial class ListarUsuarios : Form
    {
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int filtroBloqueados = this.chkFiltarBloqueados.Checked ? 1 : 0;

            List<SEG.Entity.Usuario> usuarios = usuarioService.Listar(filtroBloqueados);

            if (usuarios != null)
            {
                this.dgvListarUsuarios.DataSource = usuarios.Select(x => new { Usuario = x.NombreUsuario, Nombre = x.Nombre, Apellido = x.Apellido, Bloqueado = x.Bloqueado }).ToList();
            }
            else
            {
                this.dgvListarUsuarios.DataSource = null;
                MessageBox.Show("No se encontraron resultados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
