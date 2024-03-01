using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioUsuario<TEntidad, TEntidadID, TEntidadIdentificacion> 
        : IListar<TEntidad, TEntidadID, TEntidadIdentificacion>
        , IValidarUsuario<TEntidadIdentificacion, TEntidadIdentificacion>
    {
        
    }
}
