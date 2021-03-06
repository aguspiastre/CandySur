﻿using CandySur.SEG.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.SEG.Repository
{
    public class Patente
    {
        private CandySur.DLL.Datos db;

        public Patente()
        {
            db = CandySur.DLL.Datos.GetInstance();
        }

        public List<Entity.Patente> Listar()
        {
            List<Entity.Patente> patentes = new List<Entity.Patente>();
            string sqlCommand = @"SELECT * FROM permiso p WHERE p.Compuesto = 0";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            foreach (DataRow row in tabla.Rows)
            {
                Entity.Patente r = new Entity.Patente
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Nombre = Util.Encrypt.Desencriptar(row["Nombre"].ToString()),
                    Compuesto = (bool)row["Compuesto"],
                    Eliminado = (bool)row["Eliminado"],
                    Descripcion = row["Descripcion"].ToString(),
                    DVH = row["DVH"].ToString()
                };

                patentes.Add(r);
            }

            return patentes;
        }

        public Entity.Patente Consultar(string nombre)
        {
            string sqlCommand = @"SELECT * FROM permiso p WHERE p.Compuesto = 0 AND p.Eliminado = 0 AND p.Nombre = " + "'" + nombre + "'";

            DataTable tabla = db.ExecuteNonQuery(sqlCommand);

            if (tabla.Rows.Count == 0)
                return null;

            Entity.Patente patente = new Entity.Patente
            {
                Id = int.Parse(tabla.Rows[0]["Id"].ToString()),
                Nombre = Util.Encrypt.Desencriptar(tabla.Rows[0]["Nombre"].ToString()),
                Compuesto = (bool)tabla.Rows[0]["Compuesto"],
                Eliminado = (bool)tabla.Rows[0]["Eliminado"],
                Descripcion = tabla.Rows[0]["Descripcion"].ToString(),
                DVH = tabla.Rows[0]["DVH"].ToString()
            };

            return patente;
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

        public int ConsultarUsuariosAsignados(int idPatente, int idUsuario)
        {
            string sqlCommand = @"SELECT COUNT(u.id) FROM usuario_permiso up
                                INNER JOIN usuario u ON u.id = up.id_usuario
                                INNER JOIN permiso p ON p.id = up.id_permiso
                                WHERE p.Eliminado = 0 AND u.Eliminado = 0 AND p.id =" + idPatente + " AND up.id_usuario <> " + idUsuario;

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }

        public int ConsultarUsuariosAsignados(int idPatente)
        {
            string sqlCommand = @"SELECT COUNT(u.id) FROM usuario_permiso up
                                INNER JOIN usuario u ON u.id = up.id_usuario
                                INNER JOIN permiso p ON p.id = up.id_permiso
                                WHERE p.Eliminado = 0 AND u.Eliminado = 0 AND p.Compuesto = 0 AND p.id =" + idPatente;

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }

        public int ConsultarUsuariosAsignadosPorPatenteYFamilia(int idPatente, int idFamilia)
        {
            string sqlCommand = @"SELECT COUNT(u.id) FROM usuario_permiso up
                                INNER JOIN usuario u ON u.id = up.id_usuario
                                INNER JOIN permiso p ON p.id = up.id_permiso
                                INNER JOIN permiso_compuesto pc on pc.Id_Permiso = p.Id
                                WHERE p.Eliminado = 0 AND u.Eliminado = 0 AND pc.Id_Permiso <>" + idFamilia + " AND pc.Id_Compuesto =" + idPatente;

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }


        public int ConsultarUsuariosAsignadosPorPatenteYFamilia(int idPatente, Entity.Usuario usuario)
        {
            string sqlCommand = @"SELECT COUNT(u.id) FROM usuario_permiso up
                                INNER JOIN usuario u ON u.id = up.id_usuario
                                INNER JOIN permiso p ON p.id = up.id_permiso
                                INNER JOIN permiso_compuesto pc on pc.Id_Permiso = p.Id
                                WHERE p.Eliminado = 0 AND u.Eliminado = 0 AND pc.Id_Compuesto =" + idPatente + " AND u.Id <>" + usuario.Id;

            return Convert.ToInt32(db.ExecuteScalar(sqlCommand));
        }

    }
}
