using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Application.Services;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Infra.Data.Context;
using Dotz.ProgramaFidelidade.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Dotz.ProgramaFidelidade.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICategoriaServices, CategoriaServices>();
            services.AddScoped<IClienteEnderecoServices, ClienteEnderecoServices>();
            services.AddScoped<IClienteServices, ClienteServices>();
            services.AddScoped<IClienteTelefoneContatoServices, ClienteTelefoneContatoServices>();
            services.AddScoped<IPedidoResgateItemServices, PedidoResgateItemServices>();
            services.AddScoped<IPedidoResgateServices, PedidoResgateServices>();
            services.AddScoped<IPontuacaoClienteServices, PontuacaoClienteServices>();
            services.AddScoped<IProdutoServices, ProdutoServices>();
            services.AddScoped<ISubCategoriaServices, SubCategoriaServices>();
            services.AddScoped<ITipoEnderecoServices, TipoEnderecoServices>();
            services.AddScoped<ITipoTelefoneContatoServices, TipoTelefoneContatoServices>();

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

            services.AddScoped<DotzContext>();
        }
    }
}
