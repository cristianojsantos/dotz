using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class ClienteServices : ServiceBase<Cliente>, IClienteServices
    {
        protected new readonly IClienteRepository _repository;

        public ClienteServices(IClienteRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
