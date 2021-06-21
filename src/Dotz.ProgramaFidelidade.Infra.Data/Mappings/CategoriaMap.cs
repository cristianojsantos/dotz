using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.ProgramaFidelidade.Infra.Data.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(p => p.CodigoCategoria)
                .HasName("Categoria_PK");

            builder.Property(p => p.DescricaoCategoria)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
