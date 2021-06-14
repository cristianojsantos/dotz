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
            CreateMap<CategoriaViewModel, Categoria>()
                .ConstructUsing(c => new Categoria(c.CodigoCategoria, c.DescricaoCategoria));
            CreateMap<ClienteEnderecoViewModel, ClienteEndereco>()
                .ConstructUsing(c => new ClienteEndereco(c.CodigoCliente,
                                                         c.CodigoTipoEndereco,
                                                         c.Logradouro,
                                                         c.NumeroEndereco,
                                                         c.Complemento,
                                                         c.Cep,
                                                         c.Bairro,
                                                         c.Cidade,
                                                         c.UF,
                                                         c.Logradouro,
                                                         c.Latitude,
                                                         c.CodigoIBGE));                                                        ;
            CreateMap<ClienteTelefoneContatoViewModel, ClienteTelefoneContato>()
                .ConstructUsing(c => new ClienteTelefoneContato(c.CodigoCliente, c.CodigoTipoContato, c.NumeroDDD, c.NumeroTelefone));
            CreateMap<ClienteViewModel, Cliente>()
                .ConstructUsing(c => new Cliente(c.CodigoCliente, c.NomeCliente, c.NumeroCPF, c.NumeroRG, c.DataNascimento, c.DataCadastro, c.DataAtualizacao)) ;
            CreateMap<PedidoResgateViewModel, PedidoResgate>()
                .ConstructUsing(c => new PedidoResgate(c.CodigoPedidoResgate, c.CodigoCliente, c.DataPedido));
            CreateMap<PedidoResgateItemViewModel, PedidoResgateItem>()
                .ConstructUsing(c => new PedidoResgateItem(c.CodigoPedidoResgate, c.CodigoCliente, c.CodigoProduto, c.ValorPontoResgate));
            CreateMap<PontuacaoClienteViewModel, PontuacaoCliente>()
                .ConstructUsing(c => new PontuacaoCliente(c.CodigoCliente, c.CodigoLancamento, c.DataLancamento, c.DataExpiracaoPontos, c.ValorPontuacao));
            CreateMap<ProdutoViewModel, Produto>()
                .ConstructUsing(c => new Produto(c.CodigoProduto, c.CodigoSubCategoria, c.CodigoCategoria, c.DescricaoProduto, c.ValorPontoResgate));
            CreateMap<SubCategoriaViewModel, SubCategoria>()
                .ConstructUsing(c => new SubCategoria(c.CodigoSubCategoria, c.CodigoCategoria, c.DescricaoSubCategoria));
            CreateMap<TipoEnderecoViewModel, TipoEndereco>()
                .ConstructUsing(c => new TipoEndereco(c.CodigoTipoEndereco, c.DescricaoTipoEndereco));
            CreateMap<TipoTelefoneContatoViewModel, TipoTelefoneContato>()
                .ConstructUsing(c => new TipoTelefoneContato(c.CodigoTipoTelefoneContato, c.DescricaoTipoTelefoneContato));
        }
    }
}
