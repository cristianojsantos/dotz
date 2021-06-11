using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.ProgramaFidelidade.Infra.Data.Mappings
{
    public class ClienteTelefoneContatoMap : IEntityTypeConfiguration<ClienteTelefoneContato>
    {
        public void Configure(EntityTypeBuilder<ClienteTelefoneContato> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
