using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioCliente<TEntidad, TEntidadID, TEntidadIdentificacion> 
        : IAgregar<TEntidad>, IEditar<TEntidad>,
          IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID, TEntidadIdentificacion>
    {

    }
}
