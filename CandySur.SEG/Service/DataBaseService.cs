using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Service
{
    public class DataBaseService
    {
        Repository.DataBase repository = new Repository.DataBase();

        public void NuevoBackup(string database, string path)
        {
            repository.NuevoBackup(database, path);
        }

        public void RealizarRestore(string database, string path)
        {
            repository.RealizarRestore(database, path);
        }
    }
}
