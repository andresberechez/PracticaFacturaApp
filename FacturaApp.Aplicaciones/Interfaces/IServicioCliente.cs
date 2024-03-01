using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FacturaApp.Dominio.Interfaces;


namespace FacturaApp.Aplicaciones.Interfaces
{
    public interface IServicioCliente<TEntidad, TEntidadID, TEntidadIdentificacion>
        : IAgregar<TEntidad>, IEditar<TEntidad>,
          IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID, TEntidadIdentificacion>
    {

    }
}
