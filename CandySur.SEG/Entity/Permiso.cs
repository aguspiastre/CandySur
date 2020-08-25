using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Entity
{
    public abstract class Permiso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public string DVH { get; set; }
        public bool Compuesto { get; set; }
        public bool Eliminado { get; set; }
    }
}
