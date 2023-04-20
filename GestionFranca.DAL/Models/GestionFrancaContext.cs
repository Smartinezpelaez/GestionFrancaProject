using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestionFranca.DAL.Models;

public partial class GestionFrancaContext : DbContext
{
    public GestionFrancaContext()
    {
    }

    public GestionFrancaContext(DbContextOptions<GestionFrancaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Elemento> Elementos { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<Tecnico> Tecnicos { get; set; }

    public virtual DbSet<TecnicoElemento> TecnicoElementos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-I0OTQSJ\\SQLEXPRESS;Database=GestionFranca;User ID=UserGestionfranca;Password=Sqa$12345;TrustServerCertificate=Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Elemento>(entity =>
        {
            entity.HasKey(e => e.ElementoId).HasName("PK__Elemento__5F6F78ED40E06856");

            entity.ToTable("Elemento");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.HasKey(e => e.SucursalId).HasName("PK__Sucursal__6CB482E1C2B2CD28");

            entity.ToTable("Sucursal");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tecnico>(entity =>
        {
            entity.HasKey(e => e.TecnicoId).HasName("PK__Tecnico__C866A05D81856084");

            entity.ToTable("Tecnico");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SueldoBase).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Tecnicos)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tecnico_Sucursal");
        });

        modelBuilder.Entity<TecnicoElemento>(entity =>
        {
            entity.HasKey(e => e.TecnicoElementoId).HasName("PK__TecnicoE__1702A79196E7DBFC");

            entity.ToTable("TecnicoElemento");

            entity.HasIndex(e => new { e.TecnicoId, e.ElementoId }, "UQ_TecnicoElemento").IsUnique();

            entity.HasOne(d => d.Elemento).WithMany(p => p.TecnicoElementos)
                .HasForeignKey(d => d.ElementoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TecnicoElemento_Elemento");

            entity.HasOne(d => d.Tecnico).WithMany(p => p.TecnicoElementos)
                .HasForeignKey(d => d.TecnicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TecnicoElemento_Tecnico");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
