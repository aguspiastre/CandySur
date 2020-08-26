using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static CandySur.SEG.Util.Enums;

namespace CandySur.SEG.Service
{
    public class Familia : Permiso
    {
        SEG.Repository.Familia repository = new Repository.Familia();
        SEG.Service.DigitoVerificador dv = new Service.DigitoVerificador();

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

                    dv.ActualizarDVV("Familia");

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

                    dv.ActualizarDVV("Familia");

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

                    dv.ActualizarDVV("Familia");

                    scope.Complete();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
                bool contieneFamilia = this.ValidarAsignacion(usuario, nombre);

                if (contieneFamilia)
                    throw new Exception("El usuario ya contiene la familia asignada.");

                Entity.Familia familia = this.Consultar(nombre) as Entity.Familia;

                return repository.Asignar(familia.Id, usuario.Id);
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
            return this.Listar().Any(f => f.Nombre == nombre);
        }

        private bool ValidarAsignacion(Entity.Usuario usuario, string nombreFamilia)
        {
            return usuario.Permisos.Any(p => p.Compuesto && p.Nombre == nombreFamilia);
        }

        private bool ValidarAsignacion(Entity.Familia familia, string nombrePatente)
        {
            return familia.Permisos.Any(p => p.Nombre == nombrePatente);
        }


        private string ConcatenarRegistro(Entity.Familia familia)
        {
            return familia.Id + familia.Nombre + familia.DVH + Convert.ToInt16(familia.Compuesto) + Convert.ToInt16(familia.Eliminado) + familia.Descripcion;
        }
    }
}
