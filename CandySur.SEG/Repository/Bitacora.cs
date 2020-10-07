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
    public class Bitacora
    {
        private CandySur.DLL.Datos db;
        public Bitacora()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }
        public int Registrar(Entity.Bitacora reg)
        {
            string sqlCommand = @"INSERT INTO bitacora (FECHA, ID_CRITICIDAD, DESCRIPCION, ID_USUARIO, DVH)
                                VALUES ("  + "'" + reg.Fecha.ToString() + "'" + "," + reg.IdCriticidad + "," + "'" + reg.Descripcion + "'" + "," + reg.IdUsuario + "," + "'" + reg.DVH + "'" +")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public List<Entity.Bitacora> Consultar(ConsultarBitacoraRequest request)
        {
            List<Entity.Bitacora> registros = new List<Entity.Bitacora>();
            string sqlCommand = @"SELECT b.Id, b.Fecha, u.Nombre_Usuario as Usuario, c.Descripcion as Criticidad, b.Descripcion, b.Id_Usuario, b.DVH FROM bitacora b 
                                INNER JOIN criticidad c on c.id = b.Id_Criticidad
                                LEFT JOIN usuario u on u.Id = b.Id_Usuario";

            string sqlWhere = " WHERE b.Fecha BETWEEN " + "'" + Convert.ToDateTime(request.FechaDesde).ToShortDateString() + "'" + " AND " + "'" + Convert.ToDateTime(request.FechaHasta).ToShortDateString() + " 23:59:59.999" + "'";

            if (request.IdCriticidad != null)
                sqlWhere += " AND c.id =" + request.IdCriticidad;

            if (request.IdUsuario != 0)
                sqlWhere += " AND b.Id_Usuario =" + request.IdUsuario;

            sqlCommand += sqlWhere;

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                Entity.Bitacora r = new Entity.Bitacora
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Usuario = row["Usuario"].ToString() == "" ? row["Usuario"].ToString() : Util.Encrypt.Desencriptar(row["Usuario"].ToString()),
                    Criticidad = row["Criticidad"].ToString(),
                    Descripcion = Util.Encrypt.Desencriptar(row["Descripcion"].ToString()),
                    Fecha = row.Field<DateTime>("Fecha"),
                    DVH = row["DVH"].ToString()
                };

                registros.Add(r);
            }

            return registros;
        }
    }
}
