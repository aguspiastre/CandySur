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
    public class Idioma
    {
        private Repository.Idioma repository;

        public Idioma()
        {
            repository = new Repository.Idioma();
        }
        public List<Entity.Idioma> ListarIdiomas()
        {
            return repository.ListarIdiomas();
        }
        public Entity.Idioma ObtenerIdiomaPrincipal()
        {
            return repository.ListarIdiomas().FirstOrDefault(i => i.Principal);
        }
        
    }
}
