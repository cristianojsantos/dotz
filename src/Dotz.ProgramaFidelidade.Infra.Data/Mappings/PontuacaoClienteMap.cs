using Dotz.ProgramaFidelidade.Domain.Models.PontuacaoContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.ProgramaFidelidade.Infra.Data.Mappings
{
    public class PontuacaoClienteMap : IEntityTypeConfiguration<PontuacaoCliente>
    {
        public void Configure(EntityTypeBuilder<PontuacaoCliente> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
