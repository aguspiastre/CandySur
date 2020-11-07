using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.DLL.Repository
{
    public class Reportes
    {
        private CandySur.DLL.Datos db;
        public Reportes()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }
        public List<BE.Golosina> GenerarReporteGolosinas(DateTime fechaDsd, DateTime fechaHst)
        {
            List<CandySur.BE.Golosina> golosinas = new List<CandySur.BE.Golosina>();
            string sqlCommand = @"SELECT SUM(Cantidad) AS Cantidad, p.Id, p.Descripcion, p.Importe FROM detalle_venta d 
                                INNER JOIN Golosina p ON P.Id = d.Id_Producto 
                                INNER JOIN Venta v on v.Id = d.Id_venta
                                WHERE d.Eliminado = 0 AND d.Id_Tipo_Producto = 1 and 
                                v.Fecha BETWEEN " + "'" + fechaDsd.ToShortDateString() + "'" +
                                " AND " + "'" + fechaHst.ToShortDateString() + " 23:59:59.999" + "'" + " GROUP BY p.Id, p.Descripcion, p.Importe ORDER BY Cantidad DESC";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Golosina g = new CandySur.BE.Golosina
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Importe = Decimal.Parse((row["Importe"].ToString()).Replace(".", ",")),
                    Stock = int.Parse(row["Cantidad"].ToString())
                };

                golosinas.Add(g);
            }

            return golosinas;
        }

        public List<CandySur.BE.Venta> GenerarReporteVentas(DateTime fechaDsd, DateTime fechaHst)
        {
            List<CandySur.BE.Venta> ventas = new List<CandySur.BE.Venta>();
            string sqlCommand = @"SELECT Id, Importe, Fecha FROM venta WHERE Eliminado = 0 AND fecha BETWEEN " + "'" + fechaDsd.ToShortDateString() + "'" + " AND " + "'" + fechaHst.ToShortDateString() + " 23:59:59.999" + "'";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Venta v = new CandySur.BE.Venta
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Fecha = DateTime.Parse(row["Fecha"].ToString()),
                    Importe = Decimal.Parse(row["Importe"].ToString().Replace(".", ",")),
                };

                ventas.Add(v);
            }

            return ventas;
        }


        public List<CandySur.BE.Paquete> GenerarReportePaquetes(DateTime fechaDsd, DateTime fechaHst)
        {
            List<CandySur.BE.Paquete> paquetes = new List<CandySur.BE.Paquete>();
            string sqlCommand = @"SELECT SUM(Cantidad) AS Cantidad, p.Id, p.Descripcion, p.Importe FROM detalle_venta d 
                                INNER JOIN Paquete p ON P.Id = d.Id_Producto 
                                INNER JOIN Venta v on v.Id = d.Id_venta
                                WHERE d.Eliminado = 0 AND d.Id_Tipo_Producto = 2 and 
                                v.Fecha BETWEEN " + "'" + fechaDsd.ToShortDateString() + "'" + 
                                " AND " + "'" + fechaHst.ToShortDateString() + " 23:59:59.999" + "'" + " GROUP BY p.Id, p.Descripcion, p.Importe ORDER BY Cantidad DESC";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Paquete p = new CandySur.BE.Paquete
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Importe = Decimal.Parse(UTIL.Encrypt.Desencriptar(row["Importe"].ToString()).Replace(".", ",")),
                    Stock = int.Parse(row["Cantidad"].ToString())
                };

                paquetes.Add(p);
            }

            return paquetes;
        }

    }
}
