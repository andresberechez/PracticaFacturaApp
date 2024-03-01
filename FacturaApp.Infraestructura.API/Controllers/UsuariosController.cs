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
    public class UsuariosController : Controller
    {

        UsuarioServicio crearServicioUsuario()
        {
            FacturasContexto db = new FacturasContexto();
            UsuarioRepositorio repo = new UsuarioRepositorio(db);
            UsuarioServicio servicio = new UsuarioServicio(repo);
            return servicio;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> listar()
        {
            var servicio = crearServicioUsuario();
            return Ok(servicio.Listar());
        }


    }
}
