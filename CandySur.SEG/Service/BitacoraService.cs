using CandySur.SEG.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Service
{
    public class BitacoraService
    {
        Repository.BitacoraRepository repository = new Repository.BitacoraRepository();
        public int Registrar(Entity.Bitacora reg)
        {
            return repository.Registrar(reg);
        }

        public List<Entity.Bitacora> Consultar(ConsultarBitacoraRequest request)
        {
            return repository.Consultar(request);
        }
    }
}
