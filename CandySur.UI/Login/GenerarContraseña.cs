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

namespace CandySur.UI.Login
{
    public partial class GenerarContraseña : Form, IIdiomaObserver
    {
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

        public GenerarContraseña()
        {
            InitializeComponent();
        }

        private void btnGenerarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                string validarCampos = this.ValidarCampos();

                if (!String.IsNullOrEmpty(validarCampos))
                {
                    MessageBox.Show(validarCampos, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usuarioService.GenerarContraseña(txtUsuario.Text, txtEmail.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private string ValidarCampos()
        {
            if (txtUsuario.Text == "")
            {
                return "El campo usuario es requerido";
            }
            if (txtEmail.Text == "")
            {
                return "El campo email es requerido";
            }

            return string.Empty;
        }

        private void GenerarContraseña_Load(object sender, EventArgs e)
        {
            this.Traducir();
            SEG.Service.IdiomaManager.Suscribir(this);
        }
    }
}
