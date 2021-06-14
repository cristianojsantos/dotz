using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class ClienteEnderecoServices : ServiceBase<ClienteEndereco>, IClienteEnderecoServices
    {
        protected new readonly IClienteEnderecoRepository _repository;

        public ClienteEnderecoServices(IClienteEnderecoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
