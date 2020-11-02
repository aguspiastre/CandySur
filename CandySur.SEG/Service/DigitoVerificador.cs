using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static CandySur.SEG.Util.Enums;

namespace CandySur.SEG.Service
{
    public class DigitoVerificador
    {
        private Repository.DigitoVerificador repository;

        public DigitoVerificador()
        {
            repository = new Repository.DigitoVerificador();
        }

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
                using (var scope = new TransactionScope())
                {
                    DataTable dvvs = repository.ListarDVV();

                    foreach (DataRow row in dvvs.Rows)
                    {
                        DataTable tabla = repository.ConsultarTabla(row["Nombre_Tabla"].ToString());

                        //Saco el solo lectura y permito null (PK)
                        if (tabla.Columns.Contains("Id"))
                        {
                            tabla.Columns["Id"].ReadOnly = false;
                            tabla.Columns["Id"].AllowDBNull = true;
                        }

                        if (tabla.Columns.Contains("DVH")) tabla.Columns.Remove("DVH");

                        foreach (DataRow r in tabla.Rows)
                        {
                            string id = r["Id"].ToString();
                            r["Id"] = DBNull.Value;

                            repository.ActualizarDVH(this.CalcularDVH(ConcatenarRegistro(r)), row["Nombre_Tabla"].ToString(), id);
                        }

                        this.ActualizarDVV(row["Nombre_Tabla"].ToString());
                    }

                    scope.Complete();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool VerificarIntegridad()
        {
            try
            {
                Service.Bitacora bitacoraService = new Service.Bitacora();
                bool resultado = true;
                bool integridadBitacora = false;
                DataTable dvvs = repository.ListarDVV();

                foreach (DataRow row in dvvs.Rows)
                {
                    DataTable tabla = repository.ConsultarTabla(row["Nombre_Tabla"].ToString());

                    if (!this.CompararDVV(row["Nombre_Tabla"].ToString(), (row["DVV"].ToString())))
                    {
                        if (row["Nombre_Tabla"].ToString() == "Bitacora")
                            integridadBitacora = true;

                        bitacoraService.Registrar(new Entity.Bitacora
                        {
                            IdCriticidad = (int)Criticidad.Alta,
                            Descripcion = "La tabla " + row["Nombre_Tabla"].ToString() + " no se encuentra en un estado valido.",
                            Fecha = DateTime.Now
                        }, integridadBitacora);

                        resultado = false;
                    }

                    //Saco el solo lectura y permito null (PK)
                    if (tabla.Columns.Contains("Id"))
                    {
                        tabla.Columns["Id"].ReadOnly = false;
                        tabla.Columns["Id"].AllowDBNull = true;
                    }

                    foreach (DataRow r in tabla.Rows)
                    {
                        string dvh = r["DVH"].ToString();

                        string id = r["Id"].ToString();

                        // Dejo vacio el dvh y el id para no tenerlo en cuenta en la generacion y comparacion.
                        r["DVH"] = string.Empty;
                        r["Id"] = DBNull.Value;

                        if (!this.CompararDVH(this.ConcatenarRegistro(r), dvh))
                        {
                            bitacoraService.Registrar(new Entity.Bitacora
                            {
                                IdCriticidad = (int)Criticidad.Alta,
                                Descripcion = "El registro con id " + id + " de la tabla " + row["Nombre_Tabla"].ToString() + " no se encuentra en un estado valido.",
                                Fecha = DateTime.Now,
                            });

                            resultado = false;
                        }
                    }
                }

                return resultado;
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

            foreach (var prop in row.ItemArray)
            {
                text += prop.ToString();
            }

            return text;
        }

    }
}
