using System;
using System.Collections.Generic;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;

namespace Dotz.ProgramaFidelidade.Domain.Models.PedidoContext
{
    public class PedidoResgate
    {
        public PedidoResgate(int codigoPedidoResgate, Guid codigoCliente, DateTime dataPedido)
        {
            CodigoPedidoResgate = codigoPedidoResgate;
            CodigoCliente = codigoCliente;
            DataPedido = dataPedido;

            PedidoResgateItem = new List<PedidoResgateItem>();
        }

        public int CodigoPedidoResgate {get; private set; }
        public Guid CodigoCliente { get; private set; }
        public DateTime DataPedido { get; private set; }

        public virtual Cliente Cliente {get;set;}
        public virtual ICollection<PedidoResgateItem> PedidoResgateItem {get;set;}
    }
}
