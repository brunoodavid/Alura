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
        }
    }
}