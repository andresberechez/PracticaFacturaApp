using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FacturaApp.Dominio
{
    public class Detalles
    {
        public long IdDetalle { get; set; }
        [ForeignKey("Factura")]
        public long IdFactura { get; set; }
        public Producto producto { get; set; }
        public decimal Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Precio { get; set; }
        public decimal IVA { get; set; }
        public decimal subtotal { get; set; }

    }

}
