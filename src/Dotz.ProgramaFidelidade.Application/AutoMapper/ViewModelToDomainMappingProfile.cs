using AutoMapper;
using Dotz.ProgramaFidelidade.Application.ViewModel;
using Dotz.ProgramaFidelidade.Domain.Models;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;
using Dotz.ProgramaFidelidade.Domain.Models.PedidoContext;
using Dotz.ProgramaFidelidade.Domain.Models.PontuacaoContext;
using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;

namespace Dotz.ProgramaFidelidade.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoriaViewModel, Categoria>();
            CreateMap<ClienteEnderecoViewModel, ClienteEndereco>();
            CreateMap<ClienteTelefoneContatoViewModel, ClienteTelefoneContato>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<PedidoResgateViewModel, PedidoResgate>();
            CreateMap<PedidoResgateItemViewModel, PedidoResgateItem>();
            CreateMap<PontuacaoClienteViewModel, PontuacaoCliente>();
            CreateMap<ProdutoViewModel, Produto>();
            CreateMap<SubCategoriaViewModel, SubCategoria>();
            CreateMap<TipoEnderecoViewModel, TipoEndereco>();
            CreateMap<TipoTelefoneContatoViewModel, TipoTelefoneContato>();
        }
    }
}
