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
        CandySur.SEG.Service.BitacoraService bitacoraService = new SEG.Service.BitacoraService();

        public ConsultarBitacora()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Enums.Criticidad criticidad = (Enums.Criticidad)cmbCriticidad.SelectedItem;

            ConsultarBitacoraRequest req = new ConsultarBitacoraRequest
            {
                FechaDesde = this.dateTimeFechaDesde.Value.Date,
                FechaHasta = this.dateTimeFechaHasta.Value.Date,
                IdCriticidad = (int)criticidad,
                IdUsuario = Convert.ToInt32(this.cmbUsuario.SelectedItem.ToString())
            };

            List<CandySur.SEG.Entity.Bitacora> list = bitacoraService.Consultar(req);

            this.dataGridBitacora.DataSource = list.Select(x => new { Usuario = x.Usuario, Evento = x.Descripcion, Fecha = x.Fecha, Criticidad = x.Criticidad }).ToList();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            cmbCriticidad.DataSource = Enum.GetValues(typeof(CandySur.SEG.Util.Enums.Criticidad));
        }
    }
}
