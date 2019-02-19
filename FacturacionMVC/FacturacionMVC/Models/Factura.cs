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
        public string Nit { get; set; }     
        public decimal MONTO { get; set;}       

        public decimal CalcularMonto(decimal subtotal)
        {
            var total = subtotal * ((decimal)subtotal);
            return total;
        }
    }
}
