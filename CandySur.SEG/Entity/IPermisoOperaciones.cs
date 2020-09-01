using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Entity
{
    public interface IPermisoOperaciones
    {
        void Agregar(Entity.Permiso permiso);
        void Eliminar(Entity.Permiso permiso);
    }
}
