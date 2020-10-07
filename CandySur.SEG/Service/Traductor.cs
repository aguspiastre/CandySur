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
    public class Traductor
    {
        private Repository.Traductor repository;

        public Traductor()
        {
            repository = new Repository.Traductor();
        }
        public List<Entity.Traduccion> ObtenerTraducciones(Entity.Idioma idioma)
        {
            return repository.ObtenerTraducciones(idioma);
        }
    }
}
