using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BE
{
    public class Proveedor
    {
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string CodPostal { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public int Eliminado { get; set; }
        public List<Producto> Golosinas { get; set; }
    }
}
