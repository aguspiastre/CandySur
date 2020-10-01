using CandySur.SEG.Request;
using CandySur.SEG.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Repository
{
    public class Usuario
    {
        private CandySur.DLL.Datos db;
        public Usuario()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }

        public int Alta(Entity.Usuario usuario)
        {
            string sqlCommand = @"INSERT INTO usuario (NOMBRE, APELLIDO, DNI, NOMBRE_USUARIO, CONTRASEÑA, DIRECCION, TELEFONO, REINTENTOS, MAIL, FECHA_NAC, ELIMINADO, BLOQUEADO, DVH)
                                VALUES (" + "'" + usuario.Nombre + "'" + "," + "'" + usuario.Apellido + "'" + "," + usuario.DNI + "," + "'" + usuario.NombreUsuario + "'" + "," +
                                "'" + usuario.Contraseña + "'" + "," + "'" + usuario.Direccion + "'" + "," + usuario.Telefono + "," + 0 + "," + "'" + usuario.Mail + "'" + "," +
                                "'" + usuario.FechaNac.ToShortDateString() + "'" + "," + Convert.ToInt16(usuario.Eliminado) + "," + Convert.ToInt16(usuario.Bloqueado) + "," + "'" + usuario.DVH + "'" + ")";

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int AumentarContador(int id, int reintentos, string DVH)
        {
            string sqlCommand = @"UPDATE Usuario SET Reintentos= " + reintentos + ", DVH=" + "'" + DVH + "'" + " WHERE Id=" + id;

            db.ExecuteSqlCommand(sqlCommand);

            return reintentos;
        }

        public int ReiniciarContador(int id, string DVH)
        {
            string sqlCommand = @"UPDATE Usuario SET Reintentos = 0 " + ", DVH=" + "'" + DVH + "'" + " WHERE Id=" + id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int BloquearUsuario(int id, string DVH)
        {
            string sqlCommand = @"UPDATE Usuario SET Bloqueado = 1 " + ", DVH=" + "'" + DVH + "'" + " WHERE Id=" + id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Desbloquear(int id, string DVH)
        {
            string sqlCommand = @"UPDATE Usuario SET Bloqueado = 0, Reintentos = 0" + ", DVH=" + "'" + DVH + "'" + " WHERE Id=" + id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int ValidarNombre(string username)
        {
            string sqlCommand = @"SELECT COUNT(*) FROM USUARIO WHERE Nombre_Usuario = " + "'" + username + "'" + " AND Eliminado = 0";

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }


        public int GenerarContraseña(Entity.Usuario usuario)
        {
            string sqlCommand = @"UPDATE Usuario SET DVH=" + "'" + usuario.DVH + "'" + "," + "Contraseña=" + "'" + usuario.Contraseña + "'" + " WHERE Id=" + usuario.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Eliminar(Entity.Usuario usuario, string DVH)
        {
            string sqlCommand = @"UPDATE Usuario SET DVH=" + "'" + DVH + "'" + "," + "Eliminado=" + Convert.ToInt16(usuario.Eliminado) + " WHERE Id=" + usuario.Id;

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int Modificar(Entity.Usuario usuario, string DVH, bool esControlCambio)
        {
            string sqlCommand = string.Empty;

            if (!esControlCambio)
            {
                sqlCommand = @"UPDATE Usuario SET DVH=" + "'" + DVH + "'" + "," + "Direccion=" + "'" + usuario.Direccion + "'" + ","
                 + "Mail=" + "'" + usuario.Mail + "'" + "," + "Telefono=" + "'" + usuario.Telefono + "'" + " WHERE Id=" + usuario.Id;
            }
            else
            {
                sqlCommand = @"UPDATE Usuario SET DVH=" + "'" + DVH + "'" + "," + "Direccion=" + "'" + usuario.Direccion + "'" + ","
                + "Mail=" + "'" + usuario.Mail + "'" + "," + "Telefono="  + usuario.Telefono  + "," + "Contraseña=" + "'" + usuario.Contraseña + "'" + ","
                + "Reintentos=" + usuario.Reintentos + "," + "Eliminado=" + Convert.ToInt16(usuario.Eliminado) +  "," + "Bloqueado=" + Convert.ToInt16(usuario.Bloqueado) + " WHERE Id=" + usuario.Id;
            }

            return db.ExecuteSqlCommand(sqlCommand);
        }

        public int ObtenerUltimoId()
        {
            string sqlCommand = @"SELECT MAX(Id) FROM USUARIO";

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }

        public Entity.Usuario Consultar(string username)
        {
            string sqlCommand = @"SELECT * FROM USUARIO WHERE Nombre_Usuario = " + "'" + username + "'" + " AND Eliminado = 0";

            DataTable tabla = db.ExecuteReader(sqlCommand);

            if (tabla.Rows.Count == 0)
                return null;

            Entity.Usuario user = new Entity.Usuario
            {
                Id = int.Parse(tabla.Rows[0]["Id"].ToString()),
                NombreUsuario = Encrypt.Desencriptar(tabla.Rows[0]["Nombre_Usuario"].ToString()),
                Mail = tabla.Rows[0]["Mail"].ToString(),
                Bloqueado = (bool)tabla.Rows[0]["Bloqueado"],
                Eliminado = (bool)tabla.Rows[0]["Eliminado"],
                Reintentos = int.Parse(tabla.Rows[0]["Reintentos"].ToString()),
                Apellido = tabla.Rows[0]["Apellido"].ToString(),
                Contraseña = tabla.Rows[0]["Contraseña"].ToString(),
                DNI = int.Parse(tabla.Rows[0]["DNI"].ToString()),
                Direccion = tabla.Rows[0]["Direccion"].ToString(),
                FechaNac = Convert.ToDateTime(tabla.Rows[0]["Fecha_Nac"].ToString()),
                Telefono = int.Parse(tabla.Rows[0]["Telefono"].ToString()),
                Nombre = tabla.Rows[0]["Nombre"].ToString()
            };

            return user;
        }

        public List<Entity.Permiso> ObtenerPermisos(int id)
        {
            string sqlCommand = @"SELECT p.Id, p.Nombre, p.Compuesto, p.Descripcion FROM usuario_permiso up
                                INNER JOIN usuario u ON u.id = up.id_usuario
                                INNER JOIN permiso p ON p.id = up.id_permiso
                                WHERE p.Eliminado = 0 AND u.id =" + id;

            DataTable tabla = db.ExecuteReader(sqlCommand);

            if (tabla.Rows.Count == 0)
                return new List<Entity.Permiso>();

            List<Entity.Permiso> permisos = new List<Entity.Permiso>();

            foreach (DataRow row in tabla.Rows)
            {
                permisos.Add(new Entity.Patente
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Nombre = Util.Encrypt.Desencriptar(row["Nombre"].ToString()),
                    Compuesto = (bool)row["Compuesto"],
                    Descripcion = row["Descripcion"].ToString()
                });
            }

            return permisos;
        }

        public List<Entity.Usuario> Listar(int filtrarBloqueados)
        {
            string sqlCommand = @"SELECT * FROM USUARIO WHERE Eliminado = 0";
            string sqlWhere = string.Empty;

            if (filtrarBloqueados == 1)
                sqlWhere = " AND Bloqueado = 1";

            if (!String.IsNullOrEmpty(sqlWhere))
                sqlCommand += sqlWhere;

            DataTable tabla = db.ExecuteReader(sqlCommand);

            if (tabla.Rows.Count == 0)
                return null;

            List<Entity.Usuario> usuarios = new List<Entity.Usuario>();

            foreach (DataRow row in tabla.Rows)
            {
                Entity.Usuario user = new Entity.Usuario
                {
                    NombreUsuario = Encrypt.Desencriptar(row["Nombre_Usuario"].ToString()),
                    Bloqueado = (bool)row["Bloqueado"],
                    Apellido = row["Apellido"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    Id = Convert.ToInt32(row["Id"].ToString())
                };

                usuarios.Add(user);
            }

            return usuarios;
        }
    }
}
