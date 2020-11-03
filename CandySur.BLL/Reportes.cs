using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CandySur.BLL
{
    public class Reportes
    {
        private CandySur.DLL.Repository.Reportes repository { get; set; }
        public Reportes()
        {
            repository = new CandySur.DLL.Repository.Reportes();
        }
        public List<BE.Golosina> GenerarReportesGolosinas(DateTime fechaDsd, DateTime fechaHst)
        {
            try
            {
                return repository.GenerarReporteGolosinas(fechaDsd, fechaHst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BE.Paquete> GenerarReportesPaquetes(DateTime fechaDsd, DateTime fechaHst)
        {
            try
            {
                return repository.GenerarReportePaquetes(fechaDsd, fechaHst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BE.Venta> GenerarReportesVentas(DateTime fechaDsd, DateTime fechaHst)
        {
            try
            {
                return repository.GenerarReporteVentas(fechaDsd, fechaHst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
