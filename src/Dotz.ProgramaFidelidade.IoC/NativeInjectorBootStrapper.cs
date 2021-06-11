using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Dotz.ProgramaFidelidade.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra Data - Repository
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IClienteEnderecoRepository, ClienteEnderecoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteTelefoneContatoRepository, ClienteTelefoneContatoRepository>();
            services.AddScoped<IPedidoResgateItemRepository, PedidoResgateItemRepository>();
            services.AddScoped<IPedidoResgateRepository, PedidoResgateRepository>();
            services.AddScoped<IPontuacaoClienteRepository, PontuacaoClienteRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ISubCategoriaRepository, SubCategoriaRepository>();
            services.AddScoped<ITipoEnderecoRepository, TipoEnderecoRepository>();
            services.AddScoped<ITipoTelefoneContatoRepository, TipoTelefoneContatoRepository>();
        }
    }
}
