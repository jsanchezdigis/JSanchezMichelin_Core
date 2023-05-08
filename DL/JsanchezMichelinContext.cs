using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DL;

public partial class JsanchezMichelinContext : DbContext
{
    public JsanchezMichelinContext()
    {
    }

    public JsanchezMichelinContext(DbContextOptions<JsanchezMichelinContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Punto> Puntos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.; Database= JSanchezMichelin; User ID=sa; TrustServerCertificate=True; Password=pass@word1;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Punto>(entity =>
        {
            entity.HasKey(e => e.IdPunto).HasName("PK__Punto__82CF7BD90CDF8C05");

            entity.ToTable("Punto");

            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.Latitud)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Longitud)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
