using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.ProgramaFidelidade.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.CodigoProduto)
                .HasName("Produto_PK");
        }
    }
}
