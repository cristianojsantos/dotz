using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotz.ProgramaFidelidade.Infra.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.CodigoCliente)
                .HasName("Cliente_PK");

            builder.Property(p => p.NomeCliente)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.NumeroCPF)
                .HasMaxLength(14)
                .HasColumnType("varchar(14)");

            builder.Property(p => p.NumeroRG)
            .HasMaxLength(14)
            .HasColumnType("varchar(14)");

            builder.Property(p => p.DataNascimento)
                .IsRequired();

            builder.Property(p => p.DataCadastro);

            builder.Property(p => p.CadastroAtivo)
                .IsRequired();

            builder.Property(p => p.LoginUsuario)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnType("varchar(15)");

            builder.Property(p => p.Senha)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar(200)");
        }
    }
}
