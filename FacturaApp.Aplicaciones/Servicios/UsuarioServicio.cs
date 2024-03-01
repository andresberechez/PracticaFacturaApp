using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FacturaApp.Dominio;
using FacturaApp.Dominio.Interfaces.Repositorios;
using FacturaApp.Aplicaciones.Interfaces;


namespace FacturaApp.Aplicaciones.Servicios
{
    public class UsuarioServicio : IServicioUsuarios<Usuarios, long, string>
    {

        private readonly IRepositorioUsuario<Usuarios, long, string> _repoUsuario;

        public UsuarioServicio(IRepositorioUsuario<Usuarios, long, string> repoUsuario)
        {
            _repoUsuario = repoUsuario;
        }

        public List<Usuarios> Listar()
        {
            return _repoUsuario.Listar();
        }

        public Usuarios ListarPorID(long entidadId)
        {
            return _repoUsuario.ListarPorID(entidadId);
        }

        public Usuarios ListarPorIdentificacion(string entidadIdentificacion)
        {
            return _repoUsuario.ListarPorIdentificacion(entidadIdentificacion);
        }

        public Usuarios ValidarUsuario(string correo, string clave)
        {

            if (correo != null && clave != null)
            {
                return _repoUsuario.ValidarUsuario(correo, clave);
            }
            else
            {
                return new Usuarios(); //cambiar
            }
            
            
        }
    }
}
