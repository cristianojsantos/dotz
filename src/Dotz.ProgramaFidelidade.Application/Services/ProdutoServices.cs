using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class ProdutoServices : ServiceBase<Produto>, IProdutoServices
    {
        protected new readonly IProdutoRepository _repository;

        public ProdutoServices(IProdutoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
