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

        public void EliminarProducto(int codigo, string tipo)
        {
            this.Detalles.Remove(this.Detalles.FirstOrDefault(d => d.Producto.Id == codigo && d.Producto.Descripcion == tipo));

            CalcularImporte();
        }

        private void CalcularImporte()
        {
            this.Importe = 0;

            foreach (var item in this.Detalles)
            {
                this.Importe += item.Importe * item.Cantidad;
            }
        }
    }
}
