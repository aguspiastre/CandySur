using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BE
{
    public class Detalle_Venta
    {
        public BE.Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
        public string DVH { get; set; }
        public int IdVenta { get; set; }
        public bool Eliminado { get; set; }
    }
}
