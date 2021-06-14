using System;
using System.Collections.Generic;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class PedidoResgateViewModel
    {
        public PedidoResgateViewModel()
        {

            PedidoResgateItem = new List<PedidoResgateItemViewModel>();
        }

        public int CodigoPedidoResgate { get; private set; }
        public Guid CodigoCliente { get; private set; }
        public DateTime DataPedido { get; private set; }

        public virtual ClienteViewModel Cliente { get; set; }
        public virtual ICollection<PedidoResgateItemViewModel> PedidoResgateItem { get; set; }
    }
}
