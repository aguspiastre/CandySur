using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Service
{
    public abstract class Permiso
    {
        public abstract List<Permiso> Listar();

        public abstract Permiso Consultar();
    }
}
