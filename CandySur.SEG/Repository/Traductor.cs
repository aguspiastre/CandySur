using CandySur.SEG.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Repository
{
    public class Traductor
    {
        private CandySur.DLL.Datos db;
        public Traductor()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }

        public List<Traduccion> ObtenerTraducciones(Entity.Idioma idioma = null)
        {
            SEG.Service.Idioma idiomaService = new Service.Idioma();

            if (idioma == null)
            {
                idioma = idiomaService.ObtenerIdiomaPrincipal();
            }

            List<Entity.Traduccion> traducciones = new List<Entity.Traduccion>();
            string sqlCommand = @"SELECT t.Traduccion, e.Nombre as Nombre_Etiqueta from Traduccion t INNER JOIN Etiqueta e on t.id_etiqueta=e.id WHERE t.id_idioma =" + idioma.Id;

            DataTable tabla = db.ExecuteReader(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                Entity.Traduccion r = new Entity.Traduccion
                {
                    Etiqueta = row["Nombre_Etiqueta"].ToString(),
                    Descripcion = row["Traduccion"].ToString(),
                };

                traducciones.Add(r);
            }

            return traducciones;
        }
    }
}
