using CandySur.SEG.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Repository
{
    public class Idioma
    {
        private CandySur.DLL.Datos db;
        public Idioma()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }

        public List<Entity.Idioma> ListarIdiomas()
        {
            List<Entity.Idioma> idiomas = new List<Entity.Idioma>();
            string sqlCommand = @"SELECT * FROM Idioma";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                Entity.Idioma r = new Entity.Idioma
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Nombre = row["Nombre"].ToString(),
                    Principal = (bool)row["Principal"],
                };

                idiomas.Add(r);
            }

            return idiomas;
        }

    }
}
