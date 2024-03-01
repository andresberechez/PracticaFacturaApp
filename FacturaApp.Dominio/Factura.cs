using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Dominio
{
    public class Factura
    {
        public long IdFactura { get; set; }
        public string Establecimiento { get; set; }
        public string PuntoEmision { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente cliente { get; set; }
        public List<Detalles> detalles { get; set; }
        public decimal Subtotal { get; set; }
        public decimal TotalIVA { get; set; }
        public decimal Total { get; set; }


    }
}
