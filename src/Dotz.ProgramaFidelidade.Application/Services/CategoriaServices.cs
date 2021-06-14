using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class CategoriaServices : ServiceBase<Categoria>, ICategoriaServices
    {
        protected new readonly ICategoriaRepository _repository;

        public CategoriaServices(ICategoriaRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
