using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BE
{
    public class Paquete : Producto
    {
        public Paquete()
        {
            this.Golosinas = new List<Producto>();
        }
        public List<Producto> Golosinas { get; set; }

        public void Agregar(Golosina golosina)
        {
            this.Golosinas.Add(golosina);
        }

        public void Eliminar(Golosina golosina)
        {
            this.Golosinas.Remove(golosina);
        }

    }
}
