﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EnvioDeEmails.Models
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
        public virtual DbSet<Classificado> Classificado { get; set; }
        public virtual DbSet<Equipamento> Equipamento { get; set; }
        public virtual DbSet<ImagemClassificado> ImagemClassificado { get; set; }
        public virtual DbSet<Interesse> Interesse { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Tw;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__CATEGORI__CD54BC5A0C1AC97F");

                entity.Property(e => e.NomeCategoria).IsUnicode(false);

                entity.Property(e => e.StatusCategoria).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Classificado>(entity =>
            {
                entity.HasKey(e => e.IdClassificado)
                    .HasName("PK__CLASSIFI__946341BD82E1A6F5");

                entity.Property(e => e.NumeroDeSerie).IsUnicode(false);

                entity.Property(e => e.StatusClassificado).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdEquipamentoNavigation)
                    .WithMany(p => p.Classificado)
                    .HasForeignKey(d => d.IdEquipamento)
                    .HasConstraintName("FK__CLASSIFIC__id_eq__45F365D3");

                entity.HasOne(d => d.IdImagemClassificadoNavigation)
                    .WithMany(p => p.Classificado)
                    .HasForeignKey(d => d.IdImagemClassificado)
                    .HasConstraintName("FK__CLASSIFIC__id_im__44FF419A");
            });

            modelBuilder.Entity<Equipamento>(entity =>
            {
                entity.HasKey(e => e.IdEquipamento)
                    .HasName("PK__EQUIPAME__B5F07F5C6F3C1E66");

                entity.Property(e => e.Alimentacao).IsUnicode(false);

                entity.Property(e => e.Dimensoes).IsUnicode(false);

                entity.Property(e => e.Hd).IsUnicode(false);

                entity.Property(e => e.Marca).IsUnicode(false);

                entity.Property(e => e.MemoriaRam).IsUnicode(false);

                entity.Property(e => e.Modelo).IsUnicode(false);

                entity.Property(e => e.NomeEquipamento).IsUnicode(false);

                entity.Property(e => e.Peso).IsUnicode(false);

                entity.Property(e => e.PlacaDeVideo).IsUnicode(false);

                entity.Property(e => e.Polegada).IsUnicode(false);

                entity.Property(e => e.Processador).IsUnicode(false);

                entity.Property(e => e.SistemaOperacional).IsUnicode(false);

                entity.Property(e => e.Ssd).IsUnicode(false);

                entity.Property(e => e.StatusEquipamento).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Equipamento)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__EQUIPAMEN__id_ca__3F466844");
            });

            modelBuilder.Entity<ImagemClassificado>(entity =>
            {
                entity.HasKey(e => e.IdImagemClassificado)
                    .HasName("PK__IMAGEM_C__8113F436FE97F8F1");

                entity.Property(e => e.ImagemPrincipal).IsUnicode(false);

                entity.Property(e => e.ImagemSec1).IsUnicode(false);

                entity.Property(e => e.ImagemSec2).IsUnicode(false);

                entity.Property(e => e.ImagemSec3).IsUnicode(false);
            });

            modelBuilder.Entity<Interesse>(entity =>
            {
                entity.HasKey(e => e.IdInteresse)
                    .HasName("PK__INTERESS__9AA7BC1AF41A07E2");

                entity.Property(e => e.Comprador).HasDefaultValueSql("((0))");

                entity.Property(e => e.DataInteresse).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusInteresse).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdClassificadoNavigation)
                    .WithMany(p => p.Interesse)
                    .HasForeignKey(d => d.IdClassificado)
                    .HasConstraintName("FK__INTERESSE__id_cl__4BAC3F29");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Interesse)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__INTERESSE__id_us__4CA06362");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__USUARIO__4E3E04AD72052698");

                entity.Property(e => e.CategoriaUsuario).HasDefaultValueSql("((1))");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.ImagemUsuario).IsUnicode(false);

                entity.Property(e => e.NomeCompleto).IsUnicode(false);

                entity.Property(e => e.NomeUsuario).IsUnicode(false);

                entity.Property(e => e.Senha).IsUnicode(false);

                entity.Property(e => e.StatusUsuario).HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
