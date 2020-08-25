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
    public class Patente : Permiso
    {
        SEG.Repository.Patente repository = new Repository.Patente();

        public override List<Entity.Permiso> Listar()
        {
            return repository.Listar();
        }

        public override Entity.Permiso Consultar(string nombre)
        {
            return repository.Consultar(nombre);
        }

        public override int Asignar(Entity.Usuario usuario, string nombre)
        {
            try
            {
                bool contienePatente = this.ValidarAsignacion(usuario, nombre);

                if (contienePatente)
                    throw new Exception("El usuario ya contiene la patente asignada.");

                Entity.Patente patente = this.Consultar(nombre) as Entity.Patente;

                return repository.Asignar(patente.Id, usuario.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override int Desasignar(Entity.Usuario usuario, string nombre)
        {
            try
            {
                Entity.Patente patente = this.Consultar(nombre) as Entity.Patente;

                if (patente == null)
                    throw new Exception("No se encontro la patente.");

                return repository.Asignar(patente.Id, usuario.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ValidarAsignacion(Entity.Usuario usuario, string nombrePatente)
        {
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
