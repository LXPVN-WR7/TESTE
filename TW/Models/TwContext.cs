using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TW.Models
{
    public partial class TwContext : DbContext
    {
        public TwContext()
        {
        }

        public TwContext(DbContextOptions<TwContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<CategoriaUsuario> CategoriaUsuario { get; set; }
        public virtual DbSet<Classificado> Classificado { get; set; }
        public virtual DbSet<Equipamento> Equipamento { get; set; }
        public virtual DbSet<Interesse> Interesse { get; set; }
        public virtual DbSet<StatusClassificado> StatusClassificado { get; set; }
        public virtual DbSet<StatusInteresse> StatusInteresse { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Tw;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__CATEGORI__CD54BC5AE3B86D2E");

                entity.Property(e => e.NomeCategoria).IsUnicode(false);
            });

            modelBuilder.Entity<CategoriaUsuario>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaUsuario)
                    .HasName("PK__CATEGORI__3D7FEF8712435F96");

                entity.Property(e => e.NomeCategoriaUsuario).IsUnicode(false);
            });

            modelBuilder.Entity<Classificado>(entity =>
            {
                entity.HasKey(e => e.IdClassificado)
                    .HasName("PK__CLASSIFI__946341BDD8D40B60");

                entity.Property(e => e.NumeroDeSerie).IsUnicode(false);

                entity.Property(e => e.Observacao).IsUnicode(false);

                entity.HasOne(d => d.IdEquipamentoNavigation)
                    .WithMany(p => p.Classificado)
                    .HasForeignKey(d => d.IdEquipamento)
                    .HasConstraintName("FK__CLASSIFIC__id_eq__4316F928");

                entity.HasOne(d => d.IdStatusClassificadoNavigation)
                    .WithMany(p => p.Classificado)
                    .HasForeignKey(d => d.IdStatusClassificado)
                    .HasConstraintName("FK__CLASSIFIC__id_st__440B1D61");
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.HasKey(e => e.IdEquipamento)
                    .HasName("PK__EQUIPAME__B5F07F5CD6ADB1E5");

                entity.Property(e => e.Descricao).IsUnicode(false);

                entity.Property(e => e.Fabricante).IsUnicode(false);

                entity.Property(e => e.Modelo).IsUnicode(false);

                entity.Property(e => e.NomeEquipamento).IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Equipamento)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__EQUIPAMEN__id_ca__3E52440B");
            });

            modelBuilder.Entity<Interesse>(entity =>
            {
                entity.HasKey(e => e.IdInteresse)
                    .HasName("PK__INTERESS__9AA7BC1AA17BB44D");

                entity.HasOne(d => d.IdClassificadoNavigation)
                    .WithMany(p => p.Interesse)
                    .HasForeignKey(d => d.IdClassificado)
                    .HasConstraintName("FK__INTERESSE__id_cl__4AB81AF0");

                entity.HasOne(d => d.IdStatusInteresseNavigation)
                    .WithMany(p => p.Interesse)
                    .HasForeignKey(d => d.IdStatusInteresse)
                    .HasConstraintName("FK__INTERESSE__id_st__49C3F6B7");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Interesse)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__INTERESSE__id_us__48CFD27E");
            });

            modelBuilder.Entity<StatusClassificado>(entity =>
            {
                entity.HasKey(e => e.IdStatusClassificado)
                    .HasName("PK__STATUS_C__218F51633B8CFCDE");

                entity.Property(e => e.NomeStatusClassificado).IsUnicode(false);
            });

            modelBuilder.Entity<StatusInteresse>(entity =>
            {
                entity.HasKey(e => e.IdStatusInteresse)
                    .HasName("PK__STATUS_I__37BBE047D8AFC90E");

                entity.Property(e => e.NomeStatusInteresse).IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIO__4E3E04AD81376122");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.NomeCompleto).IsUnicode(false);

                entity.Property(e => e.NomeUsuario).IsUnicode(false);

                entity.Property(e => e.Senha).IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaUsuarioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdCategoriaUsuario)
                    .HasConstraintName("FK__USUARIO__id_cate__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
