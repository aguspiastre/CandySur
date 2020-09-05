using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static CandySur.SEG.Util.Enums;

namespace CandySur.SEG.Service
{
    public class Familia 
    {
        private SEG.Repository.Familia repository;
        private SEG.Service.DigitoVerificador dv;

        public Familia()
        {
            repository = new Repository.Familia();
            dv = new Service.DigitoVerificador();
        }

        public int Alta(Entity.Familia familia)
        {
            try
            {
                bool exiteFamilia = this.ValidarFamilia(familia.Nombre);

                if (exiteFamilia)
                    throw new Exception("La familia ya se encuentra dado de alta.");

                familia.Nombre = Util.Encrypt.Encriptar(familia.Nombre, (int)TipoEncriptacion.Reversible);
                //Generacion DVH
                familia.DVH = dv.CalcularDVH(this.ConcatenarRegistro(familia));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.Alta(familia);

                    dv.ActualizarDVV("Permiso");

                    scope.Complete();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Eliminar(Entity.Familia familia)
        {
            try
            {
                familia.Nombre = Util.Encrypt.Encriptar(familia.Nombre, (int)TipoEncriptacion.Reversible);
                familia.Eliminado = true;

                



                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.Eliminar(familia, dv.CalcularDVH(this.ConcatenarRegistro(familia)));

                    dv.ActualizarDVV("Permiso");

                    scope.Complete();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Modificar(Entity.Familia familia)
        {
            try
            {
                familia.Nombre = Util.Encrypt.Encriptar(familia.Nombre, (int)TipoEncriptacion.Reversible);

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    int result = repository.Modificar(familia, dv.CalcularDVH(this.ConcatenarRegistro(familia)));

                    dv.ActualizarDVV("Permiso");

                    scope.Complete();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Entity.Familia> Listar()
        {
            return repository.Listar();
        }

        public Entity.Familia Consultar(string nombre)
        {
            return repository.Consultar(Util.Encrypt.Encriptar(nombre, (int)TipoEncriptacion.Reversible));
        }

        public int Asignar(Entity.Usuario usuario, string nombre)
        {
            try
            {
                bool contieneFamilia = this.ValidarAsignacion(usuario, nombre);

                if (contieneFamilia)
                    throw new Exception("El usuario ya contiene la familia asignada.");

                Entity.Familia familia = this.Consultar(nombre);

                return repository.Asignar(familia.Id, usuario.Id);
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
                Entity.Permiso permiso = this.Consultar(nombre);

                if (permiso == null)
                    throw new Exception("No se encontro la familia");

                return repository.Desasignar(permiso.Id, usuario.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Asignar(Entity.Familia familia, Entity.Patente patente)
        {
            try
            {
                bool contienePatente = this.ValidarAsignacion(familia, patente.Nombre);

                if (contienePatente)
                    throw new Exception("El usuario ya contiene la familia asignada.");

                return repository.AsignarPatente(familia.Id, patente.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Desasignar(Entity.Familia familia, Entity.Patente patente)
        {
            try
            {
                return repository.DesasignarPatente(familia.Id, patente.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidarFamilia(string nombre)
        {
            return this.Listar().Any(f => f.Nombre.ToUpper() == nombre.ToUpper());
        }

        private bool ValidarAsignacion(Entity.Usuario usuario, string nombreFamilia)
        {
            if (usuario.Permisos != null)
                return usuario.Permisos.Any(p => p.Compuesto && p.Nombre == nombreFamilia);

            return false;
        }

        private bool ValidarAsignacion(Entity.Familia familia, string nombrePatente)
        {
            if (familia.Permisos == null)
                return false;

            return familia.Permisos.Any(p => p.Nombre == nombrePatente);
        }


        private string ConcatenarRegistro(Entity.Familia familia)
        {
            return familia.Nombre + familia.Compuesto + familia.Eliminado + familia.Descripcion;
        }
    }
}
