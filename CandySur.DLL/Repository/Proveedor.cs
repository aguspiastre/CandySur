using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.DLL.Repository
{
    public class Proveedor
    {
        private CandySur.DLL.Datos db;
        public Proveedor()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }
        public List<CandySur.BE.Producto> ConsultarGolosinasProveedor(string cuit)
        {
            List<CandySur.BE.Producto> productos = new List<CandySur.BE.Producto>();
            string sqlCommand = @"SELECT g.Id, g.Descripcion, g.Importe, g.Stock FROM Golosina g 
                                INNER JOIN proveedor_golosina pg on pg.Id_Golosina = g.Id
								WHERE pg.Id_Proveedor =" + cuit;

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Producto p = new CandySur.BE.Golosina
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Descripcion = row["Descripcion"].ToString(),
                    Importe = Convert.ToDecimal(row["Importe"].ToString()),
                    Stock = int.Parse(row["Stock"].ToString())
                };

                productos.Add(p);
            }

            return productos;
        }
    }
}
