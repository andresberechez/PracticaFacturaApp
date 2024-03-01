using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Dominio.Interfaces
{
    public interface IListar<TEntidad, TEntidadID, TEntidadIdentificacion>
    {
        List<TEntidad> Listar();
        TEntidad ListarPorID(TEntidadID entidadId);
        TEntidad ListarPorIdentificacion(TEntidadIdentificacion entidadIdentificacion);
    }
}
