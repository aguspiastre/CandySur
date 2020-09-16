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

namespace CandySur.UI.Familia
{
    public partial class ListarFamilias : Form, IIdiomaObserver
    {
        private SEG.Service.SessionManager Session;
        SEG.Service.Familia familiaService = new SEG.Service.Familia();
        public ListarFamilias()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarFamilias_Load(object sender, EventArgs e)
        {
            Session = SEG.Service.SessionManager.GetInstance();
            this.Traducir();
            SEG.Service.IdiomaManager.Suscribir(this);

            this.dgvFamilias.DataSource = familiaService.Listar().Select(x => new { Nombre = x.Nombre, Descripcion = x.Descripcion }).ToList();
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
    }
}
