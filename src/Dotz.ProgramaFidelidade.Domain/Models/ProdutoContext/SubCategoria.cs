namespace Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext
{
    public class SubCategoria
    {
        public SubCategoria(int codigoSubCategoria, int codigoCategoria, string descricaoSubCategoria)
        {
            CodigoSubCategoria = codigoSubCategoria;
            CodigoCategoria = codigoCategoria;
            DescricaoSubCategoria = descricaoSubCategoria;
        }

        public int CodigoSubCategoria { get; private set; }
        public int CodigoCategoria { get; private set; }
        public string DescricaoSubCategoria { get; private set; }

        public virtual Categoria Categoria { get; set; }

        public override string ToString()
        {
            return DescricaoSubCategoria.ToString().Trim();
        }
    }
}
