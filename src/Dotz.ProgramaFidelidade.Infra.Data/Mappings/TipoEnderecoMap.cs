using Dotz.ProgramaFidelidade.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.ProgramaFidelidade.Infra.Data.Mappings
{
    public class TipoEnderecoMap : IEntityTypeConfiguration<TipoEndereco>
    {
        public void Configure(EntityTypeBuilder<TipoEndereco> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
