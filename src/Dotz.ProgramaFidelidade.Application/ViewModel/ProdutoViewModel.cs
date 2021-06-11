using System.Collections.Generic;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel(int codigoProduto, int codigoSubCategoria, int codigoCategoria, string descricaoProduto, decimal valorPontoResgate)
        {
            CodigoProduto = codigoProduto;
            CodigoSubCategoria = codigoSubCategoria;
            CodigoCategoria = codigoCategoria;
            DescricaoProduto = descricaoProduto;
            ValorPontoResgate = valorPontoResgate;

            PedidoResgateItem = new List<PedidoResgateItem>();
        }

        public int CodigoProduto { get; private set; }
        public int CodigoSubCategoria { get; private set; }
        public int CodigoCategoria { get; private set; }
        public string DescricaoProduto { get; private set; }
        public decimal ValorPontoResgate { get; private set; }

        public virtual SubCategoriaViewModel SubCategoria { get; set; }
        public virtual ICollection<PedidoResgateItem> PedidoResgateItem { get; set; }



        public override string ToString()
        {
            return DescricaoProduto.ToUpper().Trim();
        }
    }
}
