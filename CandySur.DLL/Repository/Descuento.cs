using CandySur.UTIL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.DLL.Repository
{
    public class Descuento
    {
        private CandySur.DLL.Datos db;
        public Descuento()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }

        public int Configurar(CandySur.BE.Descuento descuento)
        {
            string sqlCommand = @"INSERT INTO Descuento (Importe, Porcentaje, Activo)
                                VALUES (" + "'" + Encrypt.Encriptar(descuento.Importe.ToString().Replace(",", "."), 1) + "'" + "," + "'" + Encrypt.Encriptar(descuento.Porcentaje.ToString().Replace(",", "."), 1) + "'" + "," + 0 + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Activar(CandySur.BE.Descuento descuento)
        {
            string sqlCommand = @"UPDATE Descuento SET Activo = 1 WHERE Id =" + descuento.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Desactivar(CandySur.BE.Descuento descuento)
        {
            string sqlCommand = @"UPDATE Descuento SET Activo = 0 WHERE Id =" + descuento.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public List<CandySur.BE.Descuento> Listar()
        {
            List<CandySur.BE.Descuento> descuentos = new List<CandySur.BE.Descuento>();
            string sqlCommand = @"SELECT * FROM Descuento";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                CandySur.BE.Descuento p = new CandySur.BE.Descuento
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Importe = Decimal.Parse(Encrypt.Desencriptar(row["Importe"].ToString())),
                    Porcentaje = Decimal.Parse(Encrypt.Desencriptar(row["Porcentaje"].ToString())),
                    Activo = bool.Parse(row["Activo"].ToString())
                };

                descuentos.Add(p);
            }

            return descuentos;
        }
    }
}
