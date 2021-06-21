using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.ProgramaFidelidade.Infra.Data.Mappings
{
    public class SubCategoriaMap : IEntityTypeConfiguration<SubCategoria>
    {
        public void Configure(EntityTypeBuilder<SubCategoria> builder)
        {
            builder.HasKey(p => new { p.CodigoSubCategoria, p.Categoria })
                .HasName("SubCategoria_PK");

            builder.Property(p => p.DescricaoSubCategoria)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(t => t.Categoria)
                .WithMany(t => t.SubCategoria)
                .HasForeignKey(p => p.CodigoCategoria)
                .HasConstraintName("SubCategoria_Categoria_FK");
        }
    }
}
