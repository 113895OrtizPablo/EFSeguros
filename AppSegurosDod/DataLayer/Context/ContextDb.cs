using DataLayer.ModelsCodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataLayer.Context
{
    public class ContextDb: DbContext
    {
        public ContextDb()
        {
            
        }
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        {
        }

        public DbSet<TipoProducto> TiposDeProductos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Poliza> Polizas { get; set; }
        public DbSet<Asegurado> Asegurados { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TipoProducto>().HasData(
                       new TipoProducto { Id = 1, Tipo = "Tipo_1" },
                       new TipoProducto { Id = 2, Tipo = "Tipo_2" },
                       new TipoProducto { Id = 3, Tipo = "Tipo_3" });

            modelBuilder.Entity<Producto>().HasData(
                      new Producto { Id = 1, Name = "Producto_1", TipoId=1 },
                      new Producto { Id = 2, Name = "Producto_2",TipoId=2 },
                      new Producto { Id = 3, Name = "Prodcuto_3",TipoId=1 });

            modelBuilder.Entity<Poliza>().HasData(
                     new Poliza { Id =1, Estado = "ACTIVO", ProductoId = 2 },
                     new Poliza { Id =2, Estado = "ACTIVO", ProductoId = 2 },
                     new Poliza { Id =3, Estado = "INACTIVO", ProductoId = 2 });


            modelBuilder.Entity<Asegurado>().HasData(
        new Asegurado { Id = Guid.NewGuid(), Estado = "ACTIVO", DNI = 165528, Nombre = "Jimena", FechaNacimiento = new DateTime(1964, 03, 30), PolizaId =1 },
        new Asegurado { Id = Guid.NewGuid(), Estado = "ACTIVO", DNI = 39498, Nombre = "Carlos", FechaNacimiento = new DateTime(2000, 07, 15), PolizaId =1 },
        new Asegurado { Id = Guid.NewGuid(), Estado = "INACTIVO", DNI = 35966, Nombre = "Guada", FechaNacimiento = new DateTime(2019, 11, 09), PolizaId = 2});
        }


    }
}
