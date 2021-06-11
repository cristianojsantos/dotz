using Dotz.ProgramaFidelidade.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.ProgramaFidelidade.Infra.Data.Mappings
{
    public class TipoTelefoneContatoMap : IEntityTypeConfiguration<TipoTelefoneContato>
    {
        public void Configure(EntityTypeBuilder<TipoTelefoneContato> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
