using CandySur.SEG.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Repository
{
    public class Patente
    {
        private CandySur.DLL.Datos db;

        public Patente()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }

        public List<Entity.Patente> Listar()
        {
            List<Entity.Patente> patentes = new List<Entity.Patente>();
            string sqlCommand = @"SELECT * FROM permiso p WHERE p.Compuesto = 0";

            DataTable tabla = db.ExecuteReader(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                Entity.Patente r = new Entity.Patente
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Nombre = Util.Encrypt.Desencriptar(row["Nombre"].ToString()),
                    Compuesto = (bool)row["Compuesto"],
                    Eliminado = (bool)row["Eliminado"],
                    Descripcion = row["Descripcion"].ToString(),
                    DVH = row["DVH"].ToString()
                };

                patentes.Add(r);
            }

            return patentes;
        }

        public Entity.Patente Consultar(string nombre)
        {
            string sqlCommand = @"SELECT * FROM permiso p WHERE p.Compuesto = 0 AND p.Eliminado = 0 AND p.Nombre = " + "'" + nombre + "'";

            DataTable tabla = db.ExecuteReader(sqlCommand);

            if (tabla.Rows.Count == 0)
                return null;

            Entity.Patente patente = new Entity.Patente
            {
                Id = int.Parse(tabla.Rows[0]["Id"].ToString()),
                Nombre = Util.Encrypt.Desencriptar(tabla.Rows[0]["Nombre"].ToString()),
                Compuesto = (bool)tabla.Rows[0]["Compuesto"],
                Eliminado = (bool)tabla.Rows[0]["Eliminado"],
                Descripcion = tabla.Rows[0]["Descripcion"].ToString(),
                DVH = tabla.Rows[0]["DVH"].ToString()
            };

            return patente;
        }

        public int Asignar(int idPermiso, int idUsuario)
        {
            string sqlCommand = @"INSERT INTO usuario_permiso (ID_PERMISO, ID_USUARIO)
                                VALUES (" + idPermiso + "," + idUsuario + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Desasignar(int idPermiso, int idUsuario)
        {
            string sqlCommand = @"DELETE FROM usuario_permiso WHERE Id_Usuario =" + idUsuario + " AND Id_Permiso =" + idPermiso;

            return db.ExecuteSqlCommand(sqlCommand);
        }
    }
}
