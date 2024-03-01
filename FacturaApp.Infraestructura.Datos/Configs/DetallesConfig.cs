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
    class DetallesConfig : IEntityTypeConfiguration<Detalles>
    {
        public void Configure(EntityTypeBuilder<Detalles> builder)
        {
            builder.ToTable("TBL_DETALLES");
            builder.HasKey(x => x.IdDetalle);



        }
    }
}
