using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BE
{
    public class Golosina : Producto
    {
        public int AlertaStock { get; set; }
        public CandySur.BE.Proveedor Proveedor { get; set; }
        public int Cantidad { get; set; }
    }

}
