using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Api.ModelsDataBase;

public partial class SegurosContext : DbContext
{
    public SegurosContext()
    {
    }

    public SegurosContext(DbContextOptions<SegurosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asegurado> Asegurados { get; set; }

    public virtual DbSet<Poliza> Polizas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<TipoProducto> TipoProductos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-228EPJJ\\SQLEXPRESS;Initial Catalog=Seguros;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asegurado>(entity =>
        {
            entity.ToTable("Asegurado");

            entity.HasIndex(e => e.PolizaId, "IX_Asegurado_PolizaId");

            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.Poliza).WithMany(p => p.Asegurados).HasForeignKey(d => d.PolizaId);
        });

        modelBuilder.Entity<Poliza>(entity =>
        {
            entity.ToTable("Poliza");

            entity.HasIndex(e => e.ProductoId, "IX_Poliza_ProductoId");

            entity.Property(e => e.Estado).HasMaxLength(50);

            entity.HasOne(d => d.Producto).WithMany(p => p.Polizas).HasForeignKey(d => d.ProductoId);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("Producto");

            entity.HasIndex(e => e.TipoId, "IX_Producto_TipoId");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Tipo).WithMany(p => p.Productos).HasForeignKey(d => d.TipoId);
        });

        modelBuilder.Entity<TipoProducto>(entity =>
        {
            entity.ToTable("TipoProducto");

            entity.Property(e => e.Tipo).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
