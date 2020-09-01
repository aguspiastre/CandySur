using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CandySur.SEG.Entity;
using static CandySur.SEG.Util.Enums;

namespace CandySur.SEG.Service
{
    public class Patente 
    {
        private SEG.Repository.Patente repository;

        public Patente()
        {
            repository = new Repository.Patente();
        }

        public List<Entity.Patente> Listar()
        {
            return repository.Listar();
        }

        public  Entity.Patente Consultar(string nombre)
        {
            return repository.Consultar(Util.Encrypt.Encriptar(nombre, (int)TipoEncriptacion.Reversible));
        }

        public int Asignar(Entity.Usuario usuario, string nombre)
        {
            try
            {
                bool contienePatente = this.ValidarAsignacion(usuario, nombre);

                if (contienePatente)
                    throw new Exception("El usuario ya contiene la patente asignada.");

                Entity.Patente patente = this.Consultar(nombre);

                return repository.Asignar(patente.Id, usuario.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Desasignar(Entity.Usuario usuario, string nombre)
        {
            try
            {
                Entity.Patente patente = this.Consultar(nombre);

                if (patente == null)
                    throw new Exception("No se encontro la patente.");

                return repository.Desasignar(patente.Id, usuario.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarAsignacion(Entity.Usuario usuario, string nombrePatente)
        {
            if (usuario.Permisos == null)
                return false;

            List<Entity.Permiso> permisos = usuario.Permisos.Where(p => p.Compuesto).ToList();

            foreach (Entity.Permiso item in permisos)
            {
                if (item is Entity.Familia)
                {
                    Entity.Familia familia = item as Entity.Familia;
                    if (familia.Permisos.Any(p => p.Nombre == nombrePatente))
                        return true;
                }
                else
                {
                    if (item.Nombre == nombrePatente)
                        return true;
                }
            }
            return false;
        }
    }
}
