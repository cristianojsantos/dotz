using Dotz.ProgramaFidelidade.Domain.Models.PedidoContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.ProgramaFidelidade.Infra.Data.Mappings
{
    public class PedidoResgateMap : IEntityTypeConfiguration<PedidoResgate>
    {
        public void Configure(EntityTypeBuilder<PedidoResgate> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
