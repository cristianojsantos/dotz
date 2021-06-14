using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class SubCategoriaServices : ServiceBase<SubCategoria>, ISubCategoriaServices
    {
        protected new readonly ISubCategoriaRepository _repository;

        public SubCategoriaServices(ISubCategoriaRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
