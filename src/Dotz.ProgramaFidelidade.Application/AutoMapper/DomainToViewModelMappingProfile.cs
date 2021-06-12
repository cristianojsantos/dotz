using AutoMapper;
using Dotz.ProgramaFidelidade.Application.ViewModel;
using Dotz.ProgramaFidelidade.Domain.Models;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;
using Dotz.ProgramaFidelidade.Domain.Models.PedidoContext;
using Dotz.ProgramaFidelidade.Domain.Models.PontuacaoContext;
using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;

namespace Dotz.ProgramaFidelidade.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Categoria, CategoriaViewModel>();
            CreateMap<ClienteEndereco, ClienteEnderecoViewModel>();
            CreateMap<ClienteTelefoneContato, ClienteTelefoneContatoViewModel>();
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<PedidoResgate, PedidoResgateViewModel>();
            CreateMap<PedidoResgateItem, PedidoResgateItemViewModel>();
            CreateMap<PontuacaoCliente, PontuacaoClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<SubCategoria, SubCategoriaViewModel>();
            CreateMap<TipoEndereco, TipoEnderecoViewModel>();
            CreateMap<TipoTelefoneContato, TipoTelefoneContatoViewModel>();
        }
    }
}
