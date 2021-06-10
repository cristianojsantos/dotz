using System.Collections.Generic;

namespace Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext
{
    public class Categoria
    {
        public Categoria(int codigoCategoria, string descricaoCategoria)
        {
            CodigoCategoria = codigoCategoria;
            DescricaoCategoria = descricaoCategoria;

            SubCategoria = new List<SubCategoria>();
        }

        public int CodigoCategoria { get; private set; }
        public string DescricaoCategoria { get; private set; }

        public virtual ICollection<SubCategoria> SubCategoria { get; set; }

        public override string ToString()
        {
            return DescricaoCategoria.ToUpper().Trim();
        }
    }
}
