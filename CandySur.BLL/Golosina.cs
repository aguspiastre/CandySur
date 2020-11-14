using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CandySur.BE;

namespace CandySur.BLL
{
    public class Golosina : Producto
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
            //Validar si forma un paquete.
            if (!this.ValidarEliminacion(golosina))
                throw new Exception("No se puede eliminar la golosina, debido a que conforma un paquete en stock.");

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

        public override void AumentarStock(CandySur.BE.Producto golosina, int aumento)
        {
            try
            {
                golosina.Stock = golosina.Stock + aumento;

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.AumentarStock((BE.Golosina)golosina);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void ReducirStock(CandySur.BE.Producto golosina, int disminucion)
        {
            try
            {
                golosina.Stock = golosina.Stock - disminucion;

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.ReducirStock((BE.Golosina)golosina);

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

        private bool ValidarEliminacion(BE.Golosina golosina)
        {
            BLL.Paquete paqueteService = new BLL.Paquete();

            List<BE.Paquete> paquetes = paqueteService.Listar();

            foreach (BE.Paquete paq in paquetes)
            {
                if (paq.Stock > 0)
                {
                    var paquete = paqueteService.ObtenerDetalle(paq.Id);

                    if (paquete.Golosinas.Any(g => g.Id == golosina.Id))
                        return false;
                }
            }

            return true;
        }
    }
}
