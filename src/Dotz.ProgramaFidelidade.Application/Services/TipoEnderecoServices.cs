using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class TipoEnderecoServices : ServiceBase<TipoEndereco>, ITipoEnderecoServices
    {
        protected new readonly ITipoEnderecoRepository _repository;

        public TipoEnderecoServices(ITipoEnderecoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
