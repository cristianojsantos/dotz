using System;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class PedidoResgateItemViewModel
    {
        public PedidoResgateItemViewModel()
        {
        }

        public int CodigoPedidoResgate { get; private set; }
        public Guid CodigoCliente { get; private set; }
        public int CodigoProduto { get; private set; }
        public decimal ValorPontoResgate { get; private set; }

        public virtual PedidoResgateViewModel PedidoResgate { get; set; }
        public virtual ProdutoViewModel Produto { get; set; }
    }
}