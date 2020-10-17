using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CandySur.BLL
{
    public class Golosina
    {
        private CandySur.DLL.Repository.Golosina repository { get; set; }
        private CandySur.SEG.Service.DigitoVerificador dv { get; set; }
        public Golosina()
        {
            repository = new CandySur.DLL.Repository.Golosina();
            dv = new CandySur.SEG.Service.DigitoVerificador();
        }
        public void Alta(CandySur.BE.Golosina golosina)
        {
            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Alta(golosina);

                    golosina.Id = repository.ObtenerUltimoId();

                    int result = repository.AltaGolosinaProveedor(golosina);

                    dv.ActualizarDVV("Golosina");

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(CandySur.BE.Golosina golosina)
        {
            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Eliminar(golosina);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(CandySur.BE.Golosina golosina)
        {
            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Modificar(golosina);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AumentarStock(CandySur.BE.Golosina golosina, int aumento)
        {
            try
            {
                golosina.Stock = golosina.Stock + aumento;

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.AumentarStock(golosina);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReducirStock(CandySur.BE.Golosina golosina, int disminucion)
        {
            try
            {
                golosina.Stock = golosina.Stock + disminucion;

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.ReducirStock(golosina);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CandySur.BE.Golosina ObtenerDetalle(int id)
        {
            try
            {
                CandySur.BE.Golosina golosina = repository.ObtenerDetalle(id);

                if (golosina == null)
                    throw new Exception("No se encontro la golosina.");

                golosina.Proveedor = this.ObtenerProveedor(golosina.Proveedor.Cuit);

                return golosina;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CandySur.BE.Proveedor ObtenerProveedor(string cuit)
        {
            return new CandySur.BLL.Proveedor().Listar().FirstOrDefault(p => p.Cuit == cuit);
        }

        public List<CandySur.BE.Golosina> Listar()
        {
            try
            {
                return repository.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
