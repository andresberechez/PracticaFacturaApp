using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Dominio
{
    public class Producto
    {
        public long IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }

    }
}
