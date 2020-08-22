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
        SEG.Entity.Usuario usuario;

        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int filtroBloqueados = this.rbtFiltarBloqueados.Checked ? 1 : 0;

            this.dgvListarUsuarios.DataSource = usuarioService.Listar(filtroBloqueados).Select(x => new { Usuario = x.NombreUsuario, Nombre = x.Nombre, Apellido = x.Apellido, Bloqueado = x.Bloqueado }).ToList();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
