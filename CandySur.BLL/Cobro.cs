using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BLL
{
    public class Cobro
    {
        public decimal Calcular(decimal importeVenta, decimal importeAbonado)
        {
            return importeVenta - importeAbonado;
        }
    }
}
