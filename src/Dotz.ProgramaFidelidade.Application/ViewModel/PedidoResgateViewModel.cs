using System;
using System.Collections.Generic;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class PedidoResgateViewModel
    {
        public PedidoResgateViewModel(int codigoPedidoResgate, Guid codigoCliente, DateTime dataPedido)
        {
            CodigoPedidoResgate = codigoPedidoResgate;
            CodigoCliente = codigoCliente;
            DataPedido = dataPedido;

            PedidoResgateItem = new List<PedidoResgateItem>();
        }

        public int CodigoPedidoResgate { get; private set; }
        public Guid CodigoCliente { get; private set; }
        public DateTime DataPedido { get; private set; }

        public virtual ClienteViewModel Cliente { get; set; }
        public virtual ICollection<PedidoResgateItem> PedidoResgateItem { get; set; }
    }
}
