using System.Collections.Generic;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel()
        {
            SubCategoria = new List<SubCategoriaViewModel>();
        }

        public int CodigoCategoria { get; private set; }
        public string DescricaoCategoria { get; private set; }

        public virtual ICollection<SubCategoriaViewModel> SubCategoria { get; set; }

        public override string ToString()
        {
            return DescricaoCategoria.ToUpper().Trim();
        }
    }
}
