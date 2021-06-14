using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class ClienteTelefoneContatoServices : ServiceBase<ClienteTelefoneContato>, IClienteTelefoneContatoServices
    {
        protected new readonly IClienteTelefoneContatoRepository _repository;

        public ClienteTelefoneContatoServices(IClienteTelefoneContatoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
