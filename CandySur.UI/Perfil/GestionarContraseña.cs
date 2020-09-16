using CandySur.SEG.Entity;
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

namespace CandySur.UI.Perfil
{
    public partial class GestionarContraseña : Form, IIdiomaObserver
    {
        private CandySur.SEG.Service.SessionManager Session;
        SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();
        SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();

        public GestionarContraseña()
        {
            Session = SEG.Service.SessionManager.GetInstance();

            InitializeComponent();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
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
                    usuarioService.CambiarContraseña(Session.Usuario.Nombre, txtContraseñaActual.Text, txtRepetirpw.Text);

                    SEG.Entity.Bitacora reg = new SEG.Entity.Bitacora
                    {
                        IdUsuario = Session.Usuario.Id,
                        IdCriticidad = (int)Enums.Criticidad.Media,
                        Fecha = DateTime.Now,
                        Descripcion = "Contraseña modificada."
                    };

                    bitacoraService.Registrar(reg);

                    MessageBox.Show("Contraseña modificada con exito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string ValidarCampos()
        {
            if (txtNuevapw.Text  == "")
            {
                return "El campo nueva contraseña es requerido.";
            }
            if (txtRepetirpw.Text == "")
            {
                return "El campo repetir contraseña es requerido.";
            }
            if (txtContraseñaActual.Text == "")
            {
                return "El campo contraseña actual es requerido.";
            }
            if (txtNuevapw.Text != txtRepetirpw.Text)
            {
                return "Las contraseñas no coinciden.";
            }

            return string.Empty;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionarContraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            SEG.Service.IdiomaManager.Desuscribir(this);
        }

        private void GestionarContraseña_Load(object sender, EventArgs e)
        {
            this.Traducir();
            SEG.Service.IdiomaManager.Suscribir(this);
        }
    }
}
