using CandySur.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CandySur.BLL
{
    public class Venta
    {
        private CandySur.DLL.Repository.Venta repository { get; set; }
        private CandySur.SEG.Service.DigitoVerificador dv { get; set; }
        public Venta()
        {
            repository = new CandySur.DLL.Repository.Venta();
            dv = new CandySur.SEG.Service.DigitoVerificador();
        }
        public void Alta(CandySur.BE.Venta venta)
        {
            BLL.Detalle_Venta detalleService = new Detalle_Venta();
            BLL.Producto productoSerive;;

            try
            {
                //Calculo DVH
                venta.Eliminado = false;
                venta.Fecha = DateTime.Now;
                venta.DVH = dv.CalcularDVH(this.ConcatenarRegistro(venta));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Alta(venta);

                    venta.Id = repository.ObtenerUltimoId();

                    foreach (var item in venta.Detalles)
                    {
                        if(item.Producto is BE.Golosina)
                        {
                            productoSerive = new BLL.Golosina();

                            detalleService.Alta(item, (int)Enums.TipoProducto.Golosina, venta.Id);

                            productoSerive.ReducirStock(item.Producto as BE.Golosina, item.Cantidad);
                        }
                        else
                        {
                            productoSerive = new BLL.Paquete();

                            detalleService.Alta(item, (int)Enums.TipoProducto.Paquete, venta.Id);

                            productoSerive.ReducirStock(item.Producto as BE.Paquete, item.Cantidad);
                        }
                    }

                    dv.ActualizarDVV("Venta");

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(CandySur.BE.Venta venta)
        {
            BLL.Detalle_Venta detalleService = new Detalle_Venta();
            BLL.Golosina golosinaService = new BLL.Golosina();
            BLL.Paquete paqueteService = new BLL.Paquete();

            if (venta.Fecha.Date != DateTime.Now.Date)
                throw new Exception("No se puede eliminar una venta que no es del dia.");

            try
            {
                //Calculo DVH
                venta.Eliminado = true;
                venta.DVH = dv.CalcularDVH(this.ConcatenarRegistro(venta));

                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
                    repository.Eliminar(venta);

                    foreach (var item in venta.Detalles)
                    {
                        item.IdVenta = venta.Id;
                        item.Eliminado = true;

                        detalleService.Eliminar(item);

                        if (item.Producto is BE.Golosina)
                        {
                            golosinaService.AumentarStock(item.Producto as BE.Golosina, item.Cantidad);
                        }
                        else
                        {
                            paqueteService.AumentarStock(item.Producto as BE.Paquete, item.Cantidad);
                        }
                    }

                    dv.ActualizarDVV("Venta");

                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CandySur.BE.Venta ObtenerDetalle(int id)
        {
            try
            {
                CandySur.BE.Venta venta = repository.ObtenerDetalle(id);

                if (venta == null)
                    throw new Exception("No se encontro la venta solicitada.");

                CandySur.BLL.Detalle_Venta detallesService = new Detalle_Venta();

                venta.Detalles = detallesService.Listar(id);

                return venta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CandySur.BE.Venta> ListarDiarias()
        {
            try
            {
                return repository.ListarDiarias();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ConcatenarRegistro(BE.Venta venta)
        {
            return venta.Importe.ToString("0.00") + venta.Fecha.ToString() + venta.Eliminado;
        }
    }
}
