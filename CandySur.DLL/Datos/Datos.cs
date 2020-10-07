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
    public sealed class Datos
    {
        private static Datos _instance = new Datos();
        private SqlConnection Conexion { get; set; }

        private Datos()
        {
            this.Conexion = new SqlConnection(ConfigurationManager.AppSettings["conn"].ToString());
        }

        public static Datos GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Datos();
            }
            return _instance;
        }

        public int ExecuteSqlCommand(string sqlString)
        {
            SqlCommand command = new SqlCommand(sqlString, this.Conexion);

            try
            {
                command.CommandType = System.Data.CommandType.Text;

                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    command.Connection.Open();

                return command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExecuteNonQuery(string sqlString)
        {
            SqlCommand command = new SqlCommand(sqlString, this.Conexion);

            try
            {
                DataTable table = new DataTable();

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
