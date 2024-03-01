using FacturaApp.Infraestructura.Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using FacturaApp.Dominio;
using FacturaApp.Infraestructura.Datos.Contextos;
using FacturaApp.Aplicaciones.Servicios;
using FacturaApp.Infraestructura.Datos.Repositorios;

using Microsoft.AspNetCore.Authorization;

namespace FacturaApp.Infraestructura.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }


        [Authorize(Roles = "ADMINISTRADOR, SUPERVISOR")]
        public IActionResult Facturas()
        {
            return View();
        }


        [Authorize(Roles = "ADMINISTRADOR")]
        public IActionResult AdministradorUsuarios()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}