using Clases.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Context
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Asegurado> Asegurado { get; set; }

        public DbSet<Poliza> Poliza { get; set; }

        public DbSet<Producto> Producto { get; set; }

        public DbSet<TipoDeProducto>  TipoProducto { get; set; }

    }
}
