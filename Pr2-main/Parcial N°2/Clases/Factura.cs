using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_N_2.Clases
{
    public class Factura
    {
        public Cliente Cliente { get; set; }
        public List<Product> productos { get; set; }
        public double Total { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public DateTime Fecha { get; set; }
        public string IdFactura { get; set; }
        public string Pago { get; set; }

    }
}
