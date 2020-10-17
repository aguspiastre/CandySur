using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BE
{
    public class Descuento
    {
        public int Id { get; set; }
        public decimal Importe { get; set; }
        public decimal Porcentaje { get; set; }
        public bool Activo { get; set; }
    }
}
