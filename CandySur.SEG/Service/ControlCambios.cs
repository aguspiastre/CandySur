using CandySur.SEG.Request;
using CandySur.SEG.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static CandySur.SEG.Util.Enums;

namespace CandySur.SEG.Service
{
    public class ControlCambios
    {
        private Repository.ControlCambios repository;

        public ControlCambios()
        {
            repository = new Repository.ControlCambios();
        }
        public int Registrar(Entity.ControlCambios reg)
        {
            return repository.Registrar(reg);
        }

        public List<Entity.ControlCambios> Consultar(int idUsuario)
        {
            return repository.Consultar(idUsuario);
        }
    }
}
