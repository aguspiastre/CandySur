using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.DLL.Repository
{
    public class Golosina
    {
        private CandySur.DLL.Datos db;
        public Golosina()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }
        public int Alta(CandySur.BE.Golosina golosina)
        {
            string sqlCommand = @"INSERT INTO Golosina (Descripcion, Importe, Stock, Eliminado, StockAlerta)
                                VALUES (" + "'" + golosina.Descripcion + "'" + "," + golosina.Importe.ToString().Replace(",", ".") + "," + golosina.Stock + "," + Convert.ToInt32(golosina.Eliminado) + "," + golosina.AlertaStock + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int ObtenerUltimoId()
        {
            string sqlCommand = @"SELECT MAX(Id) FROM Golosina";

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }

        public int AltaGolosinaProveedor(CandySur.BE.Golosina golosina)
        {
            string sqlCommand = @"INSERT INTO Proveedor_Golosina (Id_Proveedor, Id_Golosina)
                                VALUES (" + golosina.Proveedor.Cuit + "," + golosina.Id + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Eliminar(CandySur.BE.Golosina golosina)
        {
            string sqlCommand = @"UPDATE Golosina SET Eliminado=" + Convert.ToInt16(golosina.Eliminado) + " WHERE Id=" + golosina.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Modificar(CandySur.BE.Golosina golosina)
        {
            string sqlCommand = @"UPDATE Golosina SET Importe="  + golosina.Importe.ToString().Replace(",", ".") + "," + "Stock=" + golosina.Stock + "," + "StockAlerta=" + golosina.AlertaStock + " WHERE Id=" + golosina.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int AumentarStock(CandySur.BE.Golosina golosina)
        {
            string sqlCommand = @"UPDATE Golosina SET Stock=" + golosina.Stock + " WHERE Id=" + golosina.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int ReducirStock(CandySur.BE.Golosina golosina)
        {
            string sqlCommand = @"UPDATE Golosina SET Stock=" + golosina.Stock + " WHERE Id=" + golosina.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public CandySur.BE.Golosina ObtenerDetalle(int id)
        {
            string sqlCommand = @"SELECT Id, StockAlerta, Stock, Eliminado, Descripcion, Importe, pg.Id_Proveedor FROM Golosina g
							      INNER JOIN proveedor_golosina pg on pg.Id_Golosina = g.Id WHERE g.Eliminado = 0 AND g.Id = " + id;

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            if (tabla.Rows.Count == 0)
                return null;

            CandySur.BE.Golosina golosina = new CandySur.BE.Golosina
            {
                Id = int.Parse(tabla.Rows[0]["Id"].ToString()),
                AlertaStock = int.Parse(tabla.Rows[0]["StockAlerta"].ToString()),
                Stock = int.Parse(tabla.Rows[0]["Stock"].ToString()),
                Eliminado = (bool)tabla.Rows[0]["Eliminado"],
                Descripcion = tabla.Rows[0]["Descripcion"].ToString(),
                Importe = Decimal.Parse(tabla.Rows[0]["Importe"].ToString()),
                Proveedor = new BE.Proveedor
                {
                    Cuit = tabla.Rows[0]["Id_Proveedor"].ToString(),
                }
            };

            return golosina;
        }

        public List<CandySur.BE.Golosina> Listar()
        {
            List<CandySur.BE.Golosina> golosinas = new List<CandySur.BE.Golosina>();
            string sqlCommand = @"SELECT Id, StockAlerta, Eliminado, Descripcion, Importe, Stock FROM Golosina g
							      WHERE g.Eliminado = 0";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Golosina p = new CandySur.BE.Golosina
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    AlertaStock = int.Parse(row["StockAlerta"].ToString()),
                    Eliminado = (bool)row["Eliminado"],
                    Importe = Decimal.Parse(row["Importe"].ToString()),
                    Stock = int.Parse(row["Stock"].ToString()),
                };

                golosinas.Add(p);
            }

            return golosinas;
        }
    }
}
