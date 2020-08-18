using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Entity
{
    public class Bitacora
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public int IdUsuario { get; set; }
        public string DVH { get; set; }
        public int IdCriticidad { get; set; }
        public string Criticidad { get; set; }

    }
}
