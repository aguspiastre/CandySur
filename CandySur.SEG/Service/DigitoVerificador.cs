using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Service
{
    public class DigitoVerificador
    {
        private Repository.DigitoVerificador repository = new Repository.DigitoVerificador();

        public string CalcularDVV(DataTable tabla)
        {
            StringBuilder text = new StringBuilder();

            foreach (DataRow row in tabla.Rows)
            {
                text.Append(row["DVH"].ToString());
            }

            return this.GenerarHash(text.ToString());
        }

        public string CalcularDVH(string registro)
        {
            return this.GenerarHash(registro);
        }

        public string ConsultarDVV(string tabla)
        {
            return repository.ConsultarDVV(tabla);
        }

        public int ActualizarDVV(string tabla)
        {
            try
            {
                DataTable table = repository.ConsultarDVH(tabla);

                string dvv = this.CalcularDVV(table);

                return repository.ActualizarDVV(dvv, tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RecalcularDVV()
        {
            try
            {
                DataTable dvvs = repository.ListarDVV();

                foreach (DataRow row in dvvs.Rows)
                {
                    DataTable tabla = repository.ConsultarTabla(row["Nombre_Tabla"].ToString());

                    foreach (DataRow r in tabla.Rows)
                    {
                        string dvh = this.CalcularDVH(ConcatenarRegistro(row));
                        repository.ActualizarDVH(dvh, row["Nombre_Tabla"].ToString(), r["Id"].ToString());
                    }

                    this.ActualizarDVV(row["Nombre_Tabla"].ToString());
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool VerificarIntegridad()
        {
            try
            {
                DataTable dvvs = repository.ListarDVV();

                foreach (DataRow row in dvvs.Rows)
                {
                    DataTable tabla = repository.ConsultarTabla(row["Nombre_Tabla"].ToString());

                    string dvv = this.CalcularDVV(tabla);

                    if (!this.CompararDVV(row["Nombre_Tabla"].ToString(), dvv))
                        return false;

                    foreach (DataRow r in tabla.Rows)
                    {
                        string registro = this.ConcatenarRegistro(r);
                        string dvh = this.CalcularDVH(registro);

                        if (!this.CompararDVH(registro, dvh))
                            return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CompararDVV(string tabla, string dvv)
        {
            DataTable table = repository.ConsultarDVH(tabla);

            return this.CalcularDVV(table) == dvv;
        }

        public bool CompararDVH(string registro, string dvh)
        {
            return this.GenerarHash(registro) == dvh;
        }

        private string GenerarHash(string text)
        {
            using (MD5 hasher = MD5.Create())
            {
                byte[] dbytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(text));
                StringBuilder sBuilder = new StringBuilder();

                for (int n = 0; n <= dbytes.Length - 1; n++)
                    sBuilder.Append(dbytes[n].ToString("X2"));

                return sBuilder.ToString();
            }
        }

        private string ConcatenarRegistro(DataRow row)
        {
            string text = string.Empty;

            foreach (DataColumn c in row.ItemArray)
            {
                text += c.ToString();
            }

            return text;
        }

    }
}
