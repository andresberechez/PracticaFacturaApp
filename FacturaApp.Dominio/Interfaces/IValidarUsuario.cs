using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Dominio.Interfaces
{
    public interface IValidarUsuario<TCorreo, TClave>
    {
        public Usuarios ValidarUsuario(TCorreo correo, TClave clave);
    }

}
