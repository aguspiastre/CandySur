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

                if(!this.ValidarDesasignacion(patente.Id , usuario.Id))
                    throw new Exception("Por normas de control interno no puede quedar zona de nadie. La patente NO contiene otra asignacion.");

                return repository.Desasignar(patente.Id, usuario.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ObtenerUsuariosAsignados(int idPatente, int idUsuario)
        {
            return this.repository.ConsultarUsuariosAsignados(idPatente, idUsuario);
        }

        public int ObtenerUsuariosAsignados(int idPatente)
        {
            return this.repository.ConsultarUsuariosAsignados(idPatente);
        }

        public int ObtenerUsuariosAsignadosPorPatenteYFamilia(int idPatente, int idFamilia)
        {
            return this.repository.ConsultarUsuariosAsignadosPorPatenteYFamilia(idPatente, idFamilia);
        }
        private bool ValidarDesasignacion(int idPatente, int idUsuario)
        {
            Service.Familia familiaService = new Service.Familia();
            Service.Patente patenteService = new Service.Patente();

            foreach (Entity.Familia item in familiaService.Listar())
            {
                if(item.Permisos.Any(p => p.Id == idPatente))
                {
                    if (familiaService.ObtenerUsuariosAsignados(item) > 0)
                        return true;
                }
            }

            if (this.ObtenerUsuariosAsignados(idPatente, idUsuario) > 0)
                return true;

            return false;
        }
        private bool ValidarAsignacion(Entity.Usuario usuario, string nombrePatente)
        {
            SEG.Service.Usuario usuarioService = new SEG.Service.Usuario();

            if (usuario.Permisos == null)
                return false;

            return usuarioService.ObtenerPermisos(usuario).Any(p => !p.Compuesto && p.Nombre == nombrePatente);
        }
    }
}
