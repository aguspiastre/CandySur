using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Entity
{
    public class Familia : Permiso, IPermisoOperaciones
    {
        public Familia()
        {
            this.Permisos = new List<Permiso>();
        }
        public List<Permiso> Permisos { get; set; }

        public void Agregar(Permiso permiso)
        {
            this.Permisos.Add(permiso);
        }

        public void Eliminar(Permiso permiso)
        {
            this.Permisos.Remove(permiso);
        }
    }
}
