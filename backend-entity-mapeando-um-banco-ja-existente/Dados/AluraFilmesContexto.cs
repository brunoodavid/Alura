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
        public DbSet<FilmeAtor> Elenco {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=SRVHDB05.hml.local; Initial Catalog=SUCOS_VENDAS_BRUNO;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
            
        }
    }
}