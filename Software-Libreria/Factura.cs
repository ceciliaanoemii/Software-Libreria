using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Libreria
{
    internal class Factura
    {
       private int idFactura { get; set; }
       private Venta venta { get; set; }

        public Factura(int idFactura, Venta venta)
        {
            this.idFactura = idFactura;
            this.venta = venta;
        }
    }
}
