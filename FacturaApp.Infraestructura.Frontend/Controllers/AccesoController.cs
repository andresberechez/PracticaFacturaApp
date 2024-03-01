using Microsoft.AspNetCore.Mvc;

using FacturaApp.Dominio;
using FacturaApp.Infraestructura.Datos.Contextos;
using FacturaApp.Aplicaciones.Servicios;
using FacturaApp.Infraestructura.Datos.Repositorios;

using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;


namespace FacturaApp.Infraestructura.Frontend.Controllers
{
    public class AccesoController : Controller
    {
        UsuarioServicio crearServicioUsuario()
        {
            FacturasContexto db = new FacturasContexto();
            UsuarioRepositorio repo = new UsuarioRepositorio(db);
            UsuarioServicio servicio = new UsuarioServicio(repo);
            return servicio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Usuarios _usuario)
        {
            if (_usuario.Correo == null || _usuario.Clave == null)
            {
                return View();
            }

            var servicio = crearServicioUsuario();
            var usuario = servicio.ValidarUsuario(_usuario.Correo, _usuario.Clave);
            
            if(usuario != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name , usuario.Nombre),
                    new Claim("Correo", usuario.Correo)
                };

                //consultando rol
                FacturasContexto _db = new FacturasContexto();
                var rol = _db.Roles.Where(r => r.IdRol == usuario.IdRol).Select(r => r.NombreRol).FirstOrDefault();
                claims.Add(new Claim(ClaimTypes.Role, rol.ToString()));
                
                //creando la cookie
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }


        public async Task<IActionResult> Salir()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Acceso");
        }

    }


}
