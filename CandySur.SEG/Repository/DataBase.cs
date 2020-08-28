using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Repository
{
    public class DataBase
    {
        CandySur.DLL.Datos db = CandySur.DLL.Datos.GetInstance();
        public void NuevoBackup(string database, string path)
        {
            db.ExecuteSqlCommand("BACKUP DATABASE " + database + " TO disk='" + path + ".bak'");
        }

        public void RealizarRestore(string database, string path)
        {
            string query = "Use Master ALTER DATABASE " + database + " SET OFFLINE WITH ROLLBACK IMMEDIATE ";
            query += "RESTORE DATABASE " + database + " FROM DISK = '" + path + "' ALTER DATABASE " + database + " SET ONLINE WITH ROLLBACK IMMEDIATE";

            db.ExecuteSqlCommand(query);
        }
    }
}
