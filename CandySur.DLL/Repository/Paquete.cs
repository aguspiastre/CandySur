using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.DLL.Repository
{
    public class Paquete
    {
        private CandySur.DLL.Datos db;
        public Paquete()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }
        public int Alta(CandySur.BE.Paquete paquete)
        {
            string sqlCommand = @"INSERT INTO Paquete (Descripcion, Importe, Stock, Eliminado)
                                VALUES (" + "'" + paquete.Descripcion + "'" + "," + "'" + UTIL.Encrypt.Encriptar(paquete.Importe.ToString(),1) + "'" + "," + "'" + UTIL.Encrypt.Encriptar(paquete.Stock.ToString(), 1) + "'" + "," + paquete.Eliminado +  ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int AltaPaqueteGolosina(CandySur.BE.Paquete paquete, CandySur.BE.Golosina golosina)
        {
            string sqlCommand = @"INSERT INTO Paquete_Golosina (Id_Paquete, Id_Golosina, Cantidad)
                                VALUES (" +  + paquete.Id + "," + golosina.Id  + "," + golosina.Cantidad + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int ObtenerUltimoId()
        {
            string sqlCommand = @"SELECT MAX(Id) FROM Paquete";

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }

        public int Eliminar(CandySur.BE.Paquete paquete)
        {
            string sqlCommand = @"UPDATE Paquete SET Eliminado = 1 WHERE Id=" + paquete.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int AumentarStock(CandySur.BE.Paquete paquete)
        {
            string sqlCommand = @"UPDATE Paquete SET Stock=" + "'" + UTIL.Encrypt.Encriptar(paquete.Stock.ToString(), 1) + "'" + " WHERE Id=" + paquete.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int ReducirStock(CandySur.BE.Paquete paquete)
        {
            string sqlCommand = @"UPDATE Paquete SET Stock=" + "'" + UTIL.Encrypt.Encriptar(paquete.Stock.ToString(), 1) + "'" + " WHERE Id=" + paquete.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public CandySur.BE.Paquete ObtenerDetalle(int id)
        {
            string sqlCommand = @"SELECT Id, Eliminado, Descripcion, Importe, Stock  FROM Paquete p
							     WHERE Eliminado = 0 AND p.Id = " + id;

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            if (tabla.Rows.Count == 0)
                return null;

            CandySur.BE.Paquete paquete = new CandySur.BE.Paquete
            {
                Id = int.Parse(tabla.Rows[0]["Id"].ToString()),
                Stock = int.Parse(UTIL.Encrypt.Desencriptar(tabla.Rows[0]["Stock"].ToString())),
                Eliminado = (bool)tabla.Rows[0]["Eliminado"],
                Descripcion = tabla.Rows[0]["Descripcion"].ToString(),
                Importe = Decimal.Parse(UTIL.Encrypt.Desencriptar(tabla.Rows[0]["Importe"].ToString())),
            };

            return paquete;
        }

        public List<CandySur.BE.Paquete> Listar()
        {
            List<CandySur.BE.Paquete> paquetes = new List<CandySur.BE.Paquete>();
            string sqlCommand = @"SELECT Id, Descripcion, Importe, Stock  FROM Paquete p
							     WHERE Eliminado = 0";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Paquete p = new CandySur.BE.Paquete
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Importe = Decimal.Parse(UTIL.Encrypt.Desencriptar(row["Importe"].ToString())),
                    Stock = int.Parse(UTIL.Encrypt.Desencriptar(row["Stock"].ToString()))
                };

                paquetes.Add(p);
            }

            return paquetes;
        }

        public void ObtenerGolosinasPaquete(CandySur.BE.Paquete paquete)
        {
            string sqlCommand = @"SELECT g.Id, g.Descripcion, g.Importe, g.Stock, pg.Cantidad FROM Golosina g
                                INNER JOIN Paquete_Golosina pg on pg.Id_Golosina = g.Id 
                                INNER JOIN Paquete p on p.Id = pg.Id_Paquete
                                WHERE g.Eliminado = 0 AND p.Eliminado = 0 AND p.Id = " + paquete.Id;

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Golosina g = new CandySur.BE.Golosina
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Importe = Decimal.Parse(row["Importe"].ToString()),
                    Stock = int.Parse(row["Stock"].ToString()),
                    Cantidad = int.Parse(row["Cantidad"].ToString()),
                };

                paquete.Golosinas.Add(g);
            }
        }
    }
}
