using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FacturaApp.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FacturaApp.Infraestructura.Datos.Configs
{
    class UsuariosConfig : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("TBL_USUARIOS");
            builder.HasKey(x => x.IdUsuario);



        }
    }
}
