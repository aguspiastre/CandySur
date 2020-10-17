using CandySur.SEG.Request;
using CandySur.SEG.Util;
using CandySur.UTIL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Repository
{
    public class ControlCambios
    {
        private CandySur.DLL.Datos db;
        public ControlCambios()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }
        public int Registrar(Entity.ControlCambios reg)
        {
            string sqlCommand = @"INSERT INTO Usuario_Hist (ID_USUARIO, NOMBRE, APELLIDO, DNI, NOMBRE_USUARIO, CONTRASEÑA, DIRECCION, TELEFONO, REINTENTOS, MAIL, FECHA_NAC, ELIMINADO, BLOQUEADO, FECHA_MODIF)
                                VALUES (" + reg.Id_Usuario + "," + "'" + reg.Nombre + "'" + "," + "'" + reg.Apellido + "'" + "," + reg.DNI + "," + "'" + reg.NombreUsuario + "'" + "," +
                    "'" + reg.Contraseña + "'" + "," + "'" + reg.Direccion + "'" + "," + reg.Telefono + "," + reg.Reintentos + "," + "'" + reg.Mail + "'" + "," +
                    "'" + reg.FechaNac.ToShortDateString() + "'" + "," + Convert.ToInt16(reg.Eliminado) + "," + Convert.ToInt16(reg.Bloqueado) + "," + "'" + reg.Fecha_Modif.ToShortDateString() + "'" + ")";


            return db.ExecuteSqlCommand(sqlCommand);
        }

        public List<Entity.ControlCambios> Consultar(int idUsuario)
        {
            List<Entity.ControlCambios> registros = new List<Entity.ControlCambios>();
            string sqlCommand = @"SELECT h.* FROM Usuario_Hist h 
                                INNER JOIN usuario u on u.Id = h.Id_Usuario";

            string sqlWhere = " WHERE h.Id_Usuario = " + idUsuario;

            sqlCommand += sqlWhere;

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                Entity.ControlCambios r = new Entity.ControlCambios
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Fecha_Modif = row.Field<DateTime>("Fecha_Modif"),
                    Id_Usuario = Convert.ToInt32(row["Id_Usuario"].ToString()),
                    NombreUsuario = Encrypt.Desencriptar(row["Nombre_Usuario"].ToString()),
                    Mail = row["Mail"].ToString(),
                    Bloqueado = (bool)row["Bloqueado"],
                    Eliminado = (bool)row["Eliminado"],
                    Reintentos = int.Parse(row["Reintentos"].ToString()),
                    Apellido = row["Apellido"].ToString(),
                    Contraseña = row["Contraseña"].ToString(),
                    DNI = int.Parse(row["DNI"].ToString()),
                    Direccion = row["Direccion"].ToString(),
                    FechaNac = Convert.ToDateTime(row["Fecha_Nac"].ToString()),
                    Telefono = int.Parse(row["Telefono"].ToString()),
                    Nombre = row["Nombre"].ToString()
                };

                registros.Add(r);
            }

            return registros;
        }
    }
}
