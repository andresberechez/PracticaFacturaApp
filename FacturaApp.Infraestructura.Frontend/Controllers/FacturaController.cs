using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;
using FacturaApp.Dominio;
using FacturaApp.Infraestructura.Datos.Contextos;
using FacturaApp.Aplicaciones.Servicios;
using FacturaApp.Infraestructura.Datos.Repositorios;



namespace FacturaApp.Infraestructura.Frontend.Controllers
{
    public class FacturaController : Controller
    {

        ClienteServicio crearServicioCliente()
        {
            FacturasContexto db = new FacturasContexto();
            ClienteRepositorio repo = new ClienteRepositorio(db);
            ClienteServicio servicio = new ClienteServicio(repo);
            return servicio;
        }


        public ActionResult Index()
        {
            return View();
        }


        //============================
        //  Primero - Buscar cliente
        //============================
        [HttpGet]
        public ActionResult BuscarCliente()
        {
            ViewBag.Message = "Cliente no encontrado.";
            return View();
        }

        [HttpPost]
        public IActionResult BuscarCliente(Cliente _cliente)
        {

            var servicio = crearServicioCliente();
            Cliente cliente = servicio.ListarPorIdentificacion(_cliente.Identificacion);

            if (cliente.Correo != null)
            {
                return View(cliente);
            }
            else
            {
                return View(cliente);
            }
            
        }


        //============================
        //  Segundo 
        //============================
        [HttpGet]
        public ActionResult CrearOrden()
        {
            FacturasContexto _db = new FacturasContexto();

            var productos = _db.Productos.ToList();
            ViewBag.Productos = productos;

            var clientes = _db.Clientes.ToList();
            ViewBag.Clientes = clientes;

            List<Detalles> detalles = new List<Detalles>(); 
            ViewBag.Detalles = detalles;

            return View();
        }

        [HttpPost]
        public IActionResult CrearOrden(Factura _factura)
        {

            if (_factura != null)
            {
                return View(_factura);
            }
            else
            {
                return View(_factura);
            }

            return View();
        }

        //============================
        //  Tercero 
        //============================

        [HttpGet]
        public ActionResult Detalle()
        {
            FacturasContexto _db = new FacturasContexto();
            var productos = _db.Productos.ToList();
            ViewBag.Productos = productos;
            return View();
        }


        [HttpPost]
        public IActionResult Detalle(Detalles _detalles) //estaba usuario
        {
            return View();
        }


        //============================
        //  Cuarto 
        //============================

        [HttpGet]
        public ActionResult PlantillaFactura()
        {
            FacturasContexto _db = new FacturasContexto();

            var productos = _db.Productos.ToList();
            ViewBag.Productos = productos;

            var clientes = _db.Clientes.ToList();
            ViewBag.Clientes = clientes;

            List<Detalles> detalles = new List<Detalles>();
            ViewBag.Detalles = detalles;

            return View();
        }

        [HttpPost]
        public IActionResult PlantillaFactura(Factura _factura)
        {

            if (_factura != null)
            {
                return View(_factura);
            }
            else
            {
                return View(_factura);
            }

            return View();
        }


        //============================
        //  Cuarto 
        //============================
        //[HttpGet("{idProducto}")]
        //public ActionResult Producto(long idProducto)
        //{
        //    FacturasContexto _db = new FacturasContexto();
        //    var producto = _db.Productos.Find(idProducto);

        //    if(producto == null)
        //    {
        //        return NotFound();
        //    }
        //    var detalles = new
        //    {
        //        codigo = producto.Codigo,
        //        descripcion = producto.Descripcion,
        //        categoria = producto.Categoria
        //    };

        //    return Json(detalles);
        //}

        //[HttpPost]
        //public IActionResult Producto(Detalles _detalles) 
        //{
        //    return View();
        //}





    }
}
