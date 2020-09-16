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

namespace CandySur.UI.Usuario
{
    public partial class ListarUsuarios : Form, IIdiomaObserver
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

        public void ActualizarIdioma(SEG.Entity.Idioma idioma)
        {
            this.Traducir();
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

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            this.Traducir();
            SEG.Service.IdiomaManager.Suscribir(this);
        }

        private void ListarUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            SEG.Service.IdiomaManager.Desuscribir(this);
        }
    }
}
