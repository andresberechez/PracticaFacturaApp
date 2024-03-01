using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FacturaApp.Dominio;
using FacturaApp.Dominio.Interfaces.Repositorios;
using FacturaApp.Infraestructura.Datos.Contextos;


namespace FacturaApp.Infraestructura.Datos.Repositorios
{
    public class UsuarioRepositorio : IRepositorioUsuario<Usuarios, long, string>
    {

        private FacturasContexto _db;

        public UsuarioRepositorio(FacturasContexto db)
        {
            _db = db;
        }

        public List<Usuarios> Listar()
        {
            return _db.Usuarios.ToList();
        }

        public Usuarios ListarPorID(long entidadId)
        {
            var usuarioSeleccionado = _db.Usuarios.Where(c => c.IdUsuario == entidadId).FirstOrDefault();
            if (usuarioSeleccionado != null)
            {
                return usuarioSeleccionado;
            }
            else
            {
                return new Usuarios();
            }
        }

        public Usuarios ListarPorIdentificacion(string entidadIdentificacion)
        {
            var usuarioSeleccionado = _db.Usuarios.Where(c => c.Nombre == entidadIdentificacion).FirstOrDefault();
            if (usuarioSeleccionado != null)
            {
                return usuarioSeleccionado;
            }
            else
            {
                return new Usuarios();
            }
        }

        public Usuarios ValidarUsuario(string correo, string clave)
        {
            var usuarioValidado = _db.Usuarios.Where(u => u.Correo == correo && u.Clave == clave).FirstOrDefault();
            return usuarioValidado;
        }
    }
}
