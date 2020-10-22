using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CandySur.BLL
{
    public class Paquete
    {
        private CandySur.DLL.Repository.Paquete repository { get; set; }
        private CandySur.SEG.Service.DigitoVerificador dv { get; set; }
        public Paquete()
        {
            repository = new CandySur.DLL.Repository.Paquete();
            dv = new CandySur.SEG.Service.DigitoVerificador();
        }
        public void Alta(CandySur.BE.Paquete paquete)
        {
            BLL.Golosina golosinaService = new BLL.Golosina();

            //Verificaicon de armado.
            this.VerificarArmadoPaquete(paquete);

            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Alta(paquete);

                    paquete.Id = repository.ObtenerUltimoId();

                    foreach (CandySur.BE.Golosina golosina in paquete.Golosinas)
                    {
                        repository.AltaPaqueteGolosina(paquete, golosina);

                        //Reduccion stock de la golosina.
                        golosinaService.ReducirStock(golosina, golosina.Cantidad * paquete.Stock);
                    }

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(CandySur.BE.Paquete paquete)
        {
            BLL.Golosina golosinaService = new BLL.Golosina();

            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Eliminar(paquete);

                    foreach (BE.Golosina item in paquete.Golosinas)
                    {
                        golosinaService.AumentarStock(item, item.Cantidad);
                    }

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AumentarStock(CandySur.BE.Paquete paquete, int aumento)
        {
            try
            {
                paquete.Stock = paquete.Stock + aumento;

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.AumentarStock(paquete);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReducirStock(CandySur.BE.Paquete paquete, int disminucion)
        {
            try
            {
                paquete.Stock = paquete.Stock - disminucion;

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.ReducirStock(paquete);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CandySur.BE.Paquete ObtenerDetalle(int id)
        {
            try
            {
                CandySur.BE.Paquete paquete = repository.ObtenerDetalle(id);

                if (paquete == null)
                    throw new Exception("No se encontro el paquete solicitado.");

                repository.ObtenerGolosinasPaquete(paquete);

                return paquete;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CandySur.BE.Paquete> Listar()
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

        private void VerificarArmadoPaquete(BE.Paquete paquete)
        {
            foreach (BE.Golosina golosina in paquete.Golosinas)
            {
                if (golosina.Cantidad > (golosina.Stock * paquete.Stock))
                    throw new Exception("No hay suficiente stock para la golosina " + golosina.Descripcion + ", Stock disponible: " + golosina.Stock + ", Stock requerido: " + golosina.Cantidad);
            }
        }
    }
}
