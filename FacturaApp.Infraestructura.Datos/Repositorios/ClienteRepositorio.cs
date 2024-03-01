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
    public class ClienteRepositorio : IRepositorioCliente<Cliente, int, string>
    {

        private FacturasContexto db;

        public ClienteRepositorio(FacturasContexto _db)
        {
            db = _db;
        }


        public Cliente Agregar(Cliente entidad)
        {
            db.Clientes.Add(entidad);
            db.SaveChanges();
            return entidad;
        }


        public void Editar(Cliente entidad)
        {
            var clienteSeleccionado = db.Clientes.Where(c => c.IdCliente == entidad.IdCliente).FirstOrDefault();
            
            if(clienteSeleccionado != null)
            {
                clienteSeleccionado.IdCliente = entidad.IdCliente;
                clienteSeleccionado.Identificacion = entidad.Identificacion;
                clienteSeleccionado.Nombre = entidad.Nombre;
                clienteSeleccionado.Direccion = entidad.Direccion;
                clienteSeleccionado.Telefono = entidad.Telefono;
                clienteSeleccionado.Correo = entidad.Correo;

                db.Entry(clienteSeleccionado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            
        }

        public void Eliminar(int entidadId)
        {
            var clienteSeleccionado = db.Clientes.Where(c => c.IdCliente == entidadId).FirstOrDefault();
            if (clienteSeleccionado != null)
            {
                db.Clientes.Remove(clienteSeleccionado);
            }
        }

        public List<Cliente> Listar()
        {
            return db.Clientes.ToList();
        }

        public Cliente ListarPorID(int entidadId)
        {
            var clienteSeleccionado = db.Clientes.Where(c => c.IdCliente == entidadId).FirstOrDefault();
            if (clienteSeleccionado != null)
            {
                return clienteSeleccionado;
            }
            else
            {
                return new Cliente();
            }
        }

        public Cliente ListarPorIdentificacion(string entidadIdentificacion)
        {

            var clienteSeleccionado = db.Clientes.Where(c => c.Identificacion == entidadIdentificacion || c.Nombre == entidadIdentificacion).FirstOrDefault();
            if ( clienteSeleccionado != null)
            {
                return clienteSeleccionado;
            }
            else
            {
                return new Cliente();
            }
            
            
        }

    }



}
