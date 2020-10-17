using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CandySur.BLL
{
    public class Descuento
    {
        private CandySur.DLL.Repository.Descuento repository { get; set; }
        private CandySur.SEG.Service.DigitoVerificador dv { get; set; }
        public Descuento()
        {
            repository = new CandySur.DLL.Repository.Descuento();
            dv = new CandySur.SEG.Service.DigitoVerificador();
        }
        public void Activar(CandySur.BE.Descuento descuento)
        {
            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Activar(descuento);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Desactivar(CandySur.BE.Descuento descuento)
        {
            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Desactivar(descuento);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Configurar(CandySur.BE.Descuento descuento)
        {
            try
            {
                if (this.ValidarExistencia(descuento))
                    throw new Exception("Ya existe una promocion vigente con las mismas caracteristicas.");

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Configurar(descuento);

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CandySur.BE.Descuento> Listar()
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

        public bool ValidarExistencia(CandySur.BE.Descuento descuento)
        {
            return repository.Listar().Any(d => d.Importe == descuento.Importe && d.Porcentaje == descuento.Porcentaje);
        }
    }
}
