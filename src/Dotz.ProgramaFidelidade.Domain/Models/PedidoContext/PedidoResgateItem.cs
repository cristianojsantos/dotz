using System;
using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;

namespace Dotz.ProgramaFidelidade.Domain.Models.PedidoContext
{
    public class PedidoResgateItem
    {
        public PedidoResgateItem(int codigoPedidoResgate, Guid codigoCliente, int codigoProduto, decimal valorPontoResgate)
        {
            CodigoPedidoResgate = codigoPedidoResgate;
            CodigoCliente = codigoCliente;
            CodigoProduto = codigoProduto;
            ValorPontoResgate = valorPontoResgate;
        }

        public int CodigoPedidoResgate { get; private set; }
        public Guid CodigoCliente { get; private set; }
        public int CodigoProduto { get; private set; }
        public decimal ValorPontoResgate { get; private set; }

        public virtual PedidoResgate PedidoResgate { get; set; }
        public virtual Produto Produto { get; set; }
    }
}