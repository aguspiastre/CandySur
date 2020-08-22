using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.DLL
{
    public class Datos
    {
        public int ExecuteSqlCommand(string sqlString)
        {
            try
            {
                SqlCommand command = new SqlCommand(sqlString, ObtenerConexion());

                command.CommandType = System.Data.CommandType.StoredProcedure;

                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    command.Connection.Open();

                return command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecuteReader(string sqlString)
        {
            try
            {
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(sqlString, ObtenerConexion());

                command.CommandType = System.Data.CommandType.Text;

                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    command.Connection.Open();

                table.Load(command.ExecuteReader());

                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ExecuteScalar(string sqlString)
        {
            try
            {
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand(sqlString, ObtenerConexion());

                command.CommandType = System.Data.CommandType.Text;

                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    command.Connection.Open();

                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private SqlConnection ObtenerConexion()
        {
            return new SqlConnection(ConfigurationManager.AppSettings["conn"].ToString());
        }
    }
}
