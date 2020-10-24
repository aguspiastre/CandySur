using CandySur.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CandySur.BLL
{
    public class Detalle_Venta
    {
        private CandySur.DLL.Repository.Detalle_Venta repository { get; set; }
        private CandySur.SEG.Service.DigitoVerificador dv { get; set; }

        public void Eliminar(CandySur.BE.Detalle_Venta detalle, int tipoProducto)
        {
            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Eliminar(detalle, dv.CalcularDVH(this.ConcatenarRegistro(detalle)), tipoProducto);

                    dv.ActualizarDVV("Detalle_Venta");

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alta(CandySur.BE.Detalle_Venta detalle, int tipoProducto, int idVenta)
        {
            try
            {
                detalle.IdVenta = idVenta;

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Alta(detalle, dv.CalcularDVH(this.ConcatenarRegistro(detalle)), tipoProducto);

                    dv.ActualizarDVV("Detalle_Venta");

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CandySur.BE.Detalle_Venta> Listar(int idVenta)
        {
            try
            {
                return repository.Listar(idVenta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ConcatenarRegistro(BE.Detalle_Venta detalle)
        {
            int tipoProducto = 0;

            if(detalle.Producto is CandySur.BE.Golosina)
            {
                tipoProducto = (int)Enums.TipoProducto.Golosina;
            }
            else
            {
                tipoProducto = (int)Enums.TipoProducto.Paquete;
            }

            return detalle.IdVenta + detalle.Producto.Id + tipoProducto + detalle.Cantidad + detalle.Importe.ToString();
        }
    }
}
