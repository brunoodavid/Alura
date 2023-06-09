using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_entity_mapeando_um_banco_ja_existente.Negocio;
using Microsoft.EntityFrameworkCore;

namespace backend_entity_mapeando_um_banco_ja_existente.Dados
{
    public class AluraFilmesContexto : DbContext
    {

        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=SRVHDB05.hml.local; Initial Catalog=SUCOS_VENDAS_BRUNO;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ator>()
                .ToTable("actor");

            modelBuilder.Entity<Ator>()
                .Property(a => a.Id)
                .HasColumnName("actor_id");

            modelBuilder.Entity<Ator>()
                .Property(a => a.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("varchar(45)")
                .IsRequired();
            
            modelBuilder.Entity<Ator>()
                .Property(a => a.UltimoNome)
                .HasColumnName("last_name")
                .HasColumnType("varchar(45)")
                .IsRequired();
            
            modelBuilder.Entity<Ator>()
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
            
            modelBuilder.Entity<Filme>()
                .ToTable("film");
            
            modelBuilder.Entity<Filme>()
                .Property(f => f.Id)
                .HasColumnName("film_id");
            
            modelBuilder.Entity<Filme>()
                .Property(f => f.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            modelBuilder.Entity<Filme>()
                .Property(f => f.Descricao)
                .HasColumnName("description")
                .HasColumnType("text");
            
            modelBuilder.Entity<Filme>()
                .Property(f => f.AnoLancamento)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");
            
            modelBuilder.Entity<Filme>()
                .Property(f => f.Duracao)
                .HasColumnName("length");
            
            modelBuilder.Entity<Filme>()
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}