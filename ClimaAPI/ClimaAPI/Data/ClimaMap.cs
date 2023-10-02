using ClimaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClimaAPI.Data
{
    public class ClimaMap : IEntityTypeConfiguration<Clima>
    {
        public void Configure(EntityTypeBuilder<Clima> builder)
        {
            builder.HasKey(e => e.codigo_icao);
            builder.Property(e => e.umidade).HasMaxLength(255);
            builder.Property(e => e.visibilidade);
            builder.Property(e => e.pressao_atmosferica);
            builder.Property(e => e.vento);
            builder.Property(e => e.direcao_vento);
            builder.Property(e => e.condicao);
            builder.Property(e => e.condicao_desc);
            builder.Property(e => e.temp);
            builder.Property(e => e.atualizado_em);
        }
    }
     
}
