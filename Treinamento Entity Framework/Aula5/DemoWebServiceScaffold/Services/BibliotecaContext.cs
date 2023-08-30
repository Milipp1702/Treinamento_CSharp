using System;
using System.Collections.Generic;
using DemoWebServiceScaffold.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebServiceScaffold.Services;

public partial class BibliotecaContext : DbContext
{
    public BibliotecaContext()
    {
    }

    public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autores { get; set; }

    public virtual DbSet<Emprestimo> Emprestimos { get; set; }

    public virtual DbSet<Livro> Livros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>(entity =>
        {
            entity.ToTable("Autor");

            entity.Property(e => e.PrimeiroNome).HasMaxLength(50);
            entity.Property(e => e.UltimoNome).HasMaxLength(50);

            entity.HasMany(d => d.Livros).WithMany(p => p.Autores)
                .UsingEntity<Dictionary<string, object>>(
                    "AutorLivro",
                    r => r.HasOne<Livro>().WithMany()
                        .HasForeignKey("IdLivro")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutorLivro_Livro"),
                    l => l.HasOne<Autor>().WithMany()
                        .HasForeignKey("IdAutor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutorLivro_Autor"),
                    j =>
                    {
                        j.HasKey("IdAutor", "IdLivro");
                        j.ToTable("AutorLivro");
                    });
        });

        modelBuilder.Entity<Emprestimo>(entity =>
        {
            entity.ToTable("Emprestimo");

            entity.Property(e => e.DataDevolucao).HasColumnType("date");
            entity.Property(e => e.DataRetirada).HasColumnType("date");

            entity.HasOne(d => d.Livro).WithMany(p => p.Emprestimos)
                .HasForeignKey(d => d.IdLivro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Emprestimo_Livro");
        });

        modelBuilder.Entity<Livro>(entity =>
        {
            entity.ToTable("Livro");

            entity.Property(e => e.Titulo).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
