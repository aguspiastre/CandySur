using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BE
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public int Stock { get; set; }
        public bool Eliminado { get; set; }
    }
}
