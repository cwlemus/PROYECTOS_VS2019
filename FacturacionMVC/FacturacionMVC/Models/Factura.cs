using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacturacionMVC.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public string NIT { get; set; }
        public decimal MONTO { get; set;}

        public decimal CalcularTotal(decimal subtotal)
        {
            decimal total = subtotal* (decimal)1.13;
            return total;
        }
    }
}
