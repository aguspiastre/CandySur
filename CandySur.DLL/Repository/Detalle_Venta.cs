using CandySur.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.DLL.Repository
{
    public class Detalle_Venta
    {
        private CandySur.DLL.Datos db;

        public Detalle_Venta()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }

        public int Alta(BE.Detalle_Venta detalle, string DVH, int tipoProducto)
        {
            string sqlCommand = @"INSERT INTO Detalle_Venta (Id_Venta, Id_Producto, Id_Tipo_Producto, Cantidad, Importe, DVH, Eliminado)
                                VALUES ("  + detalle.IdVenta + "," + detalle.Producto.Id + "," + tipoProducto + "," + detalle.Cantidad + "," 
                                + detalle.Importe.ToString("0.00").Replace(",",".") + "," + "'" + DVH + "'" + "," + Convert.ToInt16(detalle.Eliminado) + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Eliminar(BE.Detalle_Venta detalle, string DVH)
        {
            string sqlCommand = @"UPDATE Detalle_Venta SET DVH=" + "'" + DVH + "'" + "," + "Eliminado=" + Convert.ToInt16(detalle.Eliminado) + 
                " WHERE Id=" + detalle.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public List<CandySur.BE.Detalle_Venta> Listar(int IdVenta)
        {
            CandySur.DLL.Repository.Paquete paqueteRepository = new CandySur.DLL.Repository.Paquete();
            CandySur.DLL.Repository.Golosina golosinaRepository = new CandySur.DLL.Repository.Golosina();

            List<CandySur.BE.Detalle_Venta> detalles = new List<CandySur.BE.Detalle_Venta>();
            string sqlCommand = @"SELECT Id, Id_Producto, Id_Tipo_Producto, Cantidad, Importe, DVH FROM Detalle_Venta
							      WHERE Id_Venta =" + IdVenta;

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Detalle_Venta d = new CandySur.BE.Detalle_Venta
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Cantidad = int.Parse(row["Cantidad"].ToString()),
                    Importe = Decimal.Parse(row["Importe"].ToString()),
                    DVH = row["DVH"].ToString(),
                };

                if (int.Parse(row["Id_Tipo_Producto"].ToString()) == (int)Enums.TipoProducto.Golosina)
                {
                    d.Producto = golosinaRepository.ObtenerDetalle(int.Parse(row["Id_Producto"].ToString()));
                }
                else
                {
                    d.Producto = paqueteRepository.ObtenerDetalle(int.Parse(row["Id_Producto"].ToString()));
                }
                 
                detalles.Add(d);
            }

            return detalles;
        }
    }
}
