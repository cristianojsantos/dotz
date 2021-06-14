using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.PontuacaoContext;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class PontuacaoClienteServices : ServiceBase<PontuacaoCliente>, IPontuacaoClienteServices
    {
        protected new readonly IPontuacaoClienteRepository _repository;

        public PontuacaoClienteServices(IPontuacaoClienteRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
