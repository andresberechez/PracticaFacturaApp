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
    public class ClienteServicio : IServicioCliente<Cliente, int, string>
    {

        private readonly IRepositorioCliente<Cliente, int, string> repoCliente;

        public ClienteServicio(IRepositorioCliente<Cliente, int, string> _repoCliente)
        {
            repoCliente = _repoCliente;
        }


        public Cliente Agregar(Cliente entidad)
        {
            if (entidad == null)
                throw new ArgumentNullException("El cliente es requerido");

            var clienteAgregado = repoCliente.Agregar(entidad);
            return clienteAgregado;
        }

        public void Editar(Cliente entidad)
        {
             repoCliente.Editar(entidad);
        }

        public void Eliminar(int entidadId)
        {
             repoCliente.Eliminar(entidadId);
        }

        public List<Cliente> Listar()
        {
            return repoCliente.Listar();
        }

        public Cliente ListarPorID(int entidadId)
        {
            return repoCliente.ListarPorID(entidadId);
        }

        public Cliente ListarPorIdentificacion(string entidadIdentificacion)
        {
            return repoCliente.ListarPorIdentificacion(entidadIdentificacion);
        }
    }
}
