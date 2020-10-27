using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.DLL.Repository
{
    public class Venta
    {
        private CandySur.DLL.Datos db;
        public Venta()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }
        public int Alta(CandySur.BE.Venta venta)
        {
            string sqlCommand = @"INSERT INTO Venta (Importe, Fecha, DVH, Eliminado)
                                VALUES (" + venta.Importe.ToString("0.00").Replace(",",".") + "," + "'" + venta.Fecha.ToString() + "'" + "," + "'" + venta.DVH + "'" + "," + Convert.ToInt16(venta.Eliminado) + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int ObtenerUltimoId()
        {
            string sqlCommand = @"SELECT MAX(Id) FROM Venta";

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }

        public int Eliminar(CandySur.BE.Venta venta)
        {
            string sqlCommand = @"UPDATE Venta SET Eliminado=" + Convert.ToInt16(venta.Eliminado) + "," + " DVH=" + "'" + venta.DVH + "'" + " WHERE Id=" + venta.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public CandySur.BE.Venta ObtenerDetalle(int id)
        {
            string sqlCommand = @"SELECT Id, Importe, Fecha, DVH, Eliminado FROM Venta v
							      WHERE v.Eliminado = 0 AND v.Id = " + id;

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            if (tabla.Rows.Count == 0)
                return null;

            CandySur.BE.Venta venta = new CandySur.BE.Venta
            {
                Id = int.Parse(tabla.Rows[0]["Id"].ToString()),
                Importe = Decimal.Parse(tabla.Rows[0]["Importe"].ToString()),
                Eliminado = (bool)tabla.Rows[0]["Eliminado"],
                Fecha = DateTime.Parse(tabla.Rows[0]["Fecha"].ToString()),
                DVH = tabla.Rows[0]["DVH"].ToString()
            };

            return venta;
        }

        public List<CandySur.BE.Venta> ListarDiarias()
        {
            List<CandySur.BE.Venta> ventas = new List<CandySur.BE.Venta>();
            string sqlCommand = @"SELECT Id, Importe, Fecha FROM Venta v
							      WHERE v.Eliminado = 0";

            sqlCommand += " AND v.Fecha BETWEEN " + "'" + DateTime.Now.ToShortDateString() + "'" + " AND " + "'" + DateTime.Now.ToShortDateString() + " 23:59:59.999" + "'";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Venta v = new CandySur.BE.Venta
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Importe = Decimal.Parse(row["Importe"].ToString()),
                    Fecha = DateTime.Parse(row["Fecha"].ToString())
                };

                ventas.Add(v);
            }

            return ventas;
        }
    }
}
