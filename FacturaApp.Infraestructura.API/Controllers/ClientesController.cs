using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using FacturaApp.Dominio;
using FacturaApp.Infraestructura.Datos.Contextos;
using FacturaApp.Infraestructura.Datos.Repositorios;
using FacturaApp.Aplicaciones.Servicios;


namespace FacturaApp.Infraestructura.API.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        ClienteServicio crearServicioCliente()
        {
            FacturasContexto db = new FacturasContexto();
            ClienteRepositorio repo = new ClienteRepositorio(db);
            ClienteServicio servicio = new ClienteServicio(repo);
            return servicio;
        }


        [HttpPost]
        public ActionResult agregar([FromBody] Cliente cliente)
        {
            var servicio = crearServicioCliente();
            servicio.Agregar(cliente);
            return new JsonResult(new { mensaje = "Cliente agregado:", cliente });
        }


        [HttpGet]
        public ActionResult<List<Cliente>> listar()
        {
            var servicio = crearServicioCliente();
            return Ok(servicio.Listar());
        }

       
        [HttpGet("{identificacion}")]
        public ActionResult<List<Cliente>> listarPorIdentificacion(string identificacion)
        {
            var servicio = crearServicioCliente();
            return Ok(servicio.ListarPorIdentificacion(identificacion));
        }



        //[HttpGet("{id:int}")]
        //public ActionResult<List<Cliente>> listarPorId(int id)
        //{
        //    var servicio = crearServicioCliente();
        //    return Ok(servicio.ListarPorID(id));
        //}

    }
}
