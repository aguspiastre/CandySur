using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandySur.BE
{
    public class Venta
    {
        public Venta()
        {
            this.Detalles = new List<Detalle_Venta>();
        }

        public List<Detalle_Venta> Detalles { get; set; }
        public int Id { get; set; }
        public decimal Importe { get; set; }
        public DateTime Fecha { get; set; }
        public bool Eliminado { get; set; }
        public string DVH { get; set; }

        public void AgregarProducto(BE.Detalle_Venta detalle)
        {
            this.Detalles.Add(detalle);
            CalcularImporte();
        }

        public void EliminarProducto(BE.Detalle_Venta detalle)
        {
            this.Detalles.Remove(detalle);
            CalcularImporte();
        }

        private void CalcularImporte()
        {
            foreach (var item in this.Detalles)
            {
                this.Importe += item.Importe * item.Cantidad;
            }
        }
    }
}
