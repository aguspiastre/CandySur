using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Entity
{
    public class Familia : Permiso
    {
        public bool Eliminado { get; set; }
        public List<Permiso> Permisos { get; set; }
    }
}
