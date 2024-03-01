using FacturaApp.Infraestructura.Datos.Contextos;
using FacturaApp.Dominio;

namespace FacturaApp.Infraestructura.Datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando la DB si no existe...");
            FacturasContexto db = new FacturasContexto();
            db.Database.EnsureCreated();
            Console.WriteLine("Listo!!");
            Console.ReadKey();


            /*
            try
            {

                Producto producto1 = new Producto();
                producto1.Codigo = "5564899";
                producto1.Descripcion = "Samsung A5";
                producto1.Categoria = "Celulares";

                Producto producto2 = new Producto();
                producto2.Codigo = "1568942";
                producto2.Descripcion = "Xiaomi redmi note 13 pro";
                producto2.Categoria = "Celulares";

                Detalles detalle1 = new Detalles();
                detalle1.producto = producto1;
                detalle1.Cantidad = 1;
                detalle1.UnidadMedida = "USD";
                detalle1.Precio = 90;
                detalle1.IVA = 15;
                detalle1.subtotal = 103;

                Detalles detalle2 = new Detalles();
                detalle2.producto = producto2;
                detalle2.Cantidad = 2;
                detalle2.UnidadMedida = "USD";
                detalle2.Precio = 300;
                detalle2.IVA = 15;
                detalle2.subtotal = 690;

                List<Detalles> detalles = new List<Detalles>();
                detalles.Add(detalle1);
                detalles.Add(detalle2);


                Cliente cliente = new Cliente();
                cliente.Identificacion = "09903";
                cliente.Nombre = "elian";
                cliente.Direccion = "florida";
                cliente.Telefono = "09903";
                cliente.Correo = "elian@mail.com";


                FacturasContexto _db = new FacturasContexto();
                Factura factura = new Factura();
                factura.Establecimiento = "001";
                factura.PuntoEmision = "001";
                factura.NumeroFactura = "0000000002";
                factura.Fecha = DateTime.Now.Date;
                factura.detalles = detalles;
                factura.Subtotal = 690;
                factura.TotalIVA = 103;
                factura.Total = 793;

                _db.Facturas.Add(factura);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("=========================================================================");
                Console.WriteLine("=========================================================================");
                Console.WriteLine("=========================================================================");
                Console.WriteLine("=========================================================================");
                Console.WriteLine("=========================================================================");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                Console.WriteLine("=========================================================================");
                Console.WriteLine("=========================================================================");
                Console.WriteLine("=========================================================================");
                Console.WriteLine("=========================================================================");
                Console.WriteLine("=========================================================================");
            }*/





        }
    }
}