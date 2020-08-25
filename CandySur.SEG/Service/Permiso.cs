using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Service
{
    public abstract class Permiso
    {
        public abstract List<Entity.Permiso> Listar();

        public abstract int Asignar(Entity.Usuario usuario, string nombre);

        public abstract int Desasignar(Entity.Usuario usuario, string nombre);

        public abstract Entity.Permiso Consultar(string nombre);
    }
}
