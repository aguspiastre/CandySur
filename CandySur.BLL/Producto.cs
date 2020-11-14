using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CandySur.BLL
{
    public abstract class Producto
    {
        public abstract void AumentarStock(CandySur.BE.Producto producto, int aumento);

        public abstract void ReducirStock(CandySur.BE.Producto producto, int disminucion);
    }
}
