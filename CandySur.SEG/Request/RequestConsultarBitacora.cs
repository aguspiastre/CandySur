using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Request
{
    public class ConsultarBitacoraRequest
    {
        public int? IdUsuario { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? IdCriticidad { get; set; }
    }
}
