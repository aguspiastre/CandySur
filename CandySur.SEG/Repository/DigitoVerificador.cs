using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Repository
{
    public class DigitoVerificador
    {
        DLL.Datos db = new DLL.Datos();

        public string ConsultarDVV(string tabla)
        {
            string sqlCommand = "SELECT DVV FROM DVV WHERE Nombre_Tabla = '" + tabla + "'";
            return db.ExecuteReader(sqlCommand).Rows[0].ToString();
        }

        public int ActualizarDVV(string cadena, string tabla)
        {
            string sqlCommand = "UPDATE DVV SET DVV = '" + cadena + "' WHERE Nombre_Tabla = '" + tabla + "'";
            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int ActualizarDVH(string cadena, string tabla, string id)
        {
            string sqlCommand = "UPDATE " + tabla + " SET DVH = '" + cadena + "' WHERE Id = '" + id + "'";
            return db.ExecuteSqlCommand(sqlCommand);
        }

        public DataTable ConsultarDVH(string tabla)
        {
            string sqlCommand = "SELECT DVH FROM " + tabla;
            return db.ExecuteReader(sqlCommand);
        }

        public DataTable ListarDVV()
        {
            string sqlCommand = "SELECT * FROM DVV";
            return db.ExecuteReader(sqlCommand);
        }

        public DataTable ConsultarTabla(string tabla)
        {
            string sqlCommand = "SELECT * FROM " + tabla;
            return db.ExecuteReader(sqlCommand);
        }
    }
}
