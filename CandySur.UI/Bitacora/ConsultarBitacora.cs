using CandySur.SEG.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandySur.SEG;
using CandySur.SEG.Util;

namespace CandySur.UI.Bitacora
{
    public partial class ConsultarBitacora : Form
    {
        private CandySur.SEG.Entity.SessionManager Session;
        CandySur.SEG.Service.Bitacora bitacoraService = new SEG.Service.Bitacora();
        CandySur.SEG.Service.Usuario usuarioSerivice = new SEG.Service.Usuario();
        public ConsultarBitacora()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Enums.Criticidad criticidad = (Enums.Criticidad)cmbCriticidad.SelectedItem;

            string value = ((KeyValuePair<string, string>)cmbUsuario.SelectedItem).Key;

            ConsultarBitacoraRequest req = new ConsultarBitacoraRequest
            {
                FechaDesde = this.dateTimeFechaDesde.Value.Date,
                FechaHasta = this.dateTimeFechaHasta.Value.Date,
                IdCriticidad = (int)criticidad,
                IdUsuario = Convert.ToInt32(value)
            };
            List<CandySur.SEG.Entity.Bitacora> list = bitacoraService.Consultar(req);

            this.dataGridBitacora.DataSource = list.Select(x => new { Usuario = x.Usuario, Evento = x.Descripcion, Fecha = x.Fecha, Criticidad = x.Criticidad }).ToList();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            Session = SEG.Entity.SessionManager.GetInstance();

            cmbCriticidad.DataSource = Enum.GetValues(typeof(CandySur.SEG.Util.Enums.Criticidad));

            Dictionary<string, string> comboUser = new Dictionary<string, string>();
            cmbUsuario.DisplayMember = "Value";
            cmbUsuario.ValueMember = "Key";
            comboUser.Add("0", "");

            foreach (var item in usuarioSerivice.Listar())
            {
                comboUser.Add(item.Id.ToString(), item.NombreUsuario);
            }

            cmbUsuario.DataSource = new BindingSource(comboUser, null);
            cmbUsuario.SelectedIndex = 0;
        }
    }
}
