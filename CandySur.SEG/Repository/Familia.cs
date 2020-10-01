using CandySur.SEG.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Repository
{
    public class Familia
    {
        private CandySur.DLL.Datos db;
        public Familia()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }

        public int Alta(Entity.Familia familia)
        {
            string sqlCommand = @"INSERT INTO permiso (NOMBRE, DVH, COMPUESTO, ELIMINADO, DESCRIPCION)
                                VALUES (" + "'" + familia.Nombre + "'" + "," + "'" + familia.DVH + "'" + "," + Convert.ToInt16(familia.Compuesto) + "," +
                     +Convert.ToInt16(familia.Eliminado) + "," + "'" + familia.Descripcion + "'" + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }
        public int Eliminar(Entity.Familia familia, string DVH)
        {
            string sqlCommand = @"UPDATE permiso SET DVH=" + "'" + DVH + "'" + "," + "Eliminado=" + Convert.ToInt16(familia.Eliminado) + " WHERE Id=" + familia.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Modificar(Entity.Familia familia, string DVH)
        {
            string sqlCommand = @"UPDATE permiso SET DVH=" + "'" + DVH + "'" + "," + "Descripcion=" + "'" + familia.Descripcion + "'" + " WHERE Id=" + familia.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Asignar(int idPermiso, int idUsuario)
        {
            string sqlCommand = @"INSERT INTO usuario_permiso (ID_PERMISO, ID_USUARIO)
                                VALUES (" + idPermiso + "," + idUsuario + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Desasignar(int idPermiso, int idUsuario)
        {
            string sqlCommand = @"DELETE FROM usuario_permiso WHERE Id_Usuario =" + idUsuario + " AND Id_Permiso =" + idPermiso;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int AsignarPatente(int idFamilia, int idPatente)
        {
            string sqlCommand = @"INSERT INTO permiso_compuesto (ID_PERMISO, ID_COMPUESTO)
                                VALUES (" + idFamilia + "," + idPatente + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int DesasignarPatente(int idFamilia, int idPatente)
        {
            string sqlCommand = @"DELETE FROM permiso_compuesto WHERE Id_Permiso =" + idFamilia + " AND Id_Compuesto =" + idPatente;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public List<Entity.Familia> Listar()
        {
            List<Entity.Familia> familias = new List<Entity.Familia>();
            string sqlCommand = @"SELECT * FROM permiso p WHERE p.Compuesto = 1 AND p.Eliminado = 0";

            DataTable tabla = db.ExecuteReader(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                Entity.Familia r = new Entity.Familia
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Nombre = Util.Encrypt.Desencriptar(row["Nombre"].ToString()),
                    Compuesto = (bool)row["Compuesto"],
                    Eliminado = (bool)row["Eliminado"],
                    Descripcion = row["Descripcion"].ToString(),
                    DVH = row["DVH"].ToString()
                };

                this.ConsultarPatentesPorFamilia(r);

                familias.Add(r);
            }

            return familias;
        }

        public Entity.Familia Consultar(string nombre)
        {
            string sqlCommand = @"SELECT * FROM permiso p WHERE p.Compuesto = 1 AND p.Eliminado = 0 AND p.Nombre = " + "'" + nombre + "'";

            DataTable tabla = db.ExecuteReader(sqlCommand);

            if (tabla.Rows.Count == 0)
                return null;

            Entity.Familia familia = new Entity.Familia
            {
                Id = int.Parse(tabla.Rows[0]["Id"].ToString()),
                Nombre = Util.Encrypt.Desencriptar(tabla.Rows[0]["Nombre"].ToString()),
                Compuesto = (bool)tabla.Rows[0]["Compuesto"],
                Eliminado = (bool)tabla.Rows[0]["Eliminado"],
                Descripcion = tabla.Rows[0]["Descripcion"].ToString(),
                DVH = tabla.Rows[0]["DVH"].ToString()
            };

            this.ConsultarPatentesPorFamilia(familia);

            return familia;
        }

        public void ConsultarPatentesPorFamilia(Entity.Familia familia)
        {
            string sqlCommand = @"SELECT c.* FROM permiso_compuesto pc
                                 INNER JOIN permiso p on p.Id = pc.Id_Permiso
                                 INNER JOIN permiso c on c.Id = pc.Id_Compuesto
                                 WHERE c.Eliminado = 0 AND p.id = " + familia.Id;

            DataTable tablaPatentes = db.ExecuteReader(sqlCommand);

            foreach (DataRow row in tablaPatentes.Rows)
            {
                familia.Permisos.Add(new Entity.Patente
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Nombre = Util.Encrypt.Desencriptar(row["Nombre"].ToString()),
                    Compuesto = (bool)row["Compuesto"],
                    Eliminado = (bool)row["Eliminado"],
                    Descripcion = row["Descripcion"].ToString(),
                    DVH = row["DVH"].ToString()
                });
            }
        }

        public int ConsultarUsuariosAsignados(Entity.Familia familia)
        {
            string sqlCommand = @"SELECT COUNT(u.id) FROM usuario_permiso up
                                INNER JOIN usuario u ON u.id = up.id_usuario
                                INNER JOIN permiso p ON p.id = up.id_permiso
                                WHERE p.Eliminado = 0 AND p.id =" + familia.Id;

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }

        public int ConsultarFamiliasAsignadas(Entity.Familia familia)
        {
            string sqlCommand = @"SELECT COUNT(u.id) FROM usuario_permiso up
                                INNER JOIN usuario u ON u.id = up.id_usuario
                                INNER JOIN permiso p ON p.id = up.id_permiso
                                WHERE p.Eliminado = 0 AND p.id <>" + familia.Id;

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }
    }
}
