using backend_entity_mapeando_um_banco_ja_existente.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_entity_mapeando_um_banco_ja_existente.Dados;

public class FilmeAtorConfiguration : IEntityTypeConfiguration<FilmeAtor>
{
    public void Configure(EntityTypeBuilder<FilmeAtor> builder)
    {
        builder.ToTable("film_actor");

        builder.Property<int>("film_id");
        builder.Property<int>("actor_id");
        builder.Property<DateTime>("last_update")
            .IsRequired()
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");
        
        builder.HasKey("film_id", "actor_id");
    }
}