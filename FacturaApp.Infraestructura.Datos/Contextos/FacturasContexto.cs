using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using FacturaApp.Infraestructura.Datos.Configs;
using FacturaApp.Dominio;
using System.Reflection.Emit;



namespace FacturaApp.Infraestructura.Datos.Contextos
{
    public class FacturasContexto : DbContext
    {

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Detalles> Detalles { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=prueba4; Integrated Security=true;")
                        .LogTo(Console.WriteLine)
                        .EnableSensitiveDataLogging(); // para pruebas
            optionsBuilder.UseSqlServer().EnableServiceProviderCaching(false);
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ClienteConfig());
            builder.ApplyConfiguration(new DetallesConfig());
            builder.ApplyConfiguration(new FacturaConfig());
            builder.ApplyConfiguration(new ProductoConfig());
            builder.ApplyConfiguration(new UsuariosConfig());
            builder.ApplyConfiguration(new RolesConfig());


            builder.Entity<Usuarios>()
            .HasOne(s => s.Roles)
            .WithMany()
            .HasForeignKey(s => s.IdRol)
            .OnDelete(DeleteBehavior.Restrict);

            
            builder.Entity<Factura>()
            .HasOne(s => s.cliente)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Factura>()
            .HasMany(s => s.detalles)
            .WithMany();

            builder.Entity<Detalles>()
            .HasOne(s => s.producto)
            .WithMany()
            .HasForeignKey(s => s.IdFactura)
            .OnDelete(DeleteBehavior.Restrict);


            //.HasMany(factura => factura.detalles)
            //.WithOne(Detalles => Detalles.producto);

        }


    }


}
