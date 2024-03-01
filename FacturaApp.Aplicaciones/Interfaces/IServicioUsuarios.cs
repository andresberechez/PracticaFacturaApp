using FacturaApp.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Aplicaciones.Interfaces
{
    public interface IServicioUsuarios<TEntidad, TEntidadID, TEntidadIdentificacion>
        : IListar<TEntidad, TEntidadID, TEntidadIdentificacion>
        , IValidarUsuario<TEntidadIdentificacion, TEntidadIdentificacion>
    {

    }
}
