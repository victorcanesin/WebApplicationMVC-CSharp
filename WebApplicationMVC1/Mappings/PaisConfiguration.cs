using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplicationMVC1.Models;

namespace WebApplicationMVC1.Mappings
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("tbl_geral_pais");

            builder.HasKey(x => x.paisCodigo);

            builder.Property(x => x.paisCodigo).HasColumnName("pais_codigo");

            builder.Property(x => x.paisDescricao).HasColumnName("pais_descricao");

            builder.Property(x => x.paisSigla).HasColumnName("pais_sigla");
        }
    }
}
