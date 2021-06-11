namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class SubCategoriaViewModel
    {
        public SubCategoriaViewModel(int codigoSubCategoria, int codigoCategoria, string descricaoSubCategoria)
        {
            CodigoSubCategoria = codigoSubCategoria;
            CodigoCategoria = codigoCategoria;
            DescricaoSubCategoria = descricaoSubCategoria;
        }

        public int CodigoSubCategoria { get; private set; }
        public int CodigoCategoria { get; private set; }
        public string DescricaoSubCategoria { get; private set; }

        public virtual CategoriaViewModel Categoria { get; set; }

        public override string ToString()
        {
            return DescricaoSubCategoria.ToString().Trim();
        }
    }
}
