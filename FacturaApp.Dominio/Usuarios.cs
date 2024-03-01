using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaApp.Dominio
{
    public class Usuarios
    {
        public long IdUsuario { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Clave { get; set; }

        [ForeignKey("Roles")]
        public long IdRol { get; set; }
        public Roles Roles { get; set; }

    }

}
