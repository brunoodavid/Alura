using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_entity_mapeando_um_banco_ja_existente.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_entity_mapeando_um_banco_ja_existente.Dados
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("film");
            
            builder
                .Property(f => f.Id)
                .HasColumnName("film_id");
            
            builder
                .Property(f => f.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property(f => f.Descricao)
                .HasColumnName("description")
                .HasColumnType("text");
            
            builder
                .Property(f => f.AnoLancamento)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");
            
            builder
                .Property(f => f.Duracao)
                .HasColumnName("length");
            
            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}