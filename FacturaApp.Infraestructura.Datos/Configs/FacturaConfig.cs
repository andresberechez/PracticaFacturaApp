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
    class FacturaConfig : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable("TBL_FACTURAS");
            builder.HasKey(x => x.IdFactura);

            //builder
            //    .HasMany(factura => factura.detalles)
            //    .WithOne(Detalles => Detalles.producto);

        }

    }
}
