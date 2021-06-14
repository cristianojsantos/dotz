using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.PedidoContext;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class PedidoResgateServices : ServiceBase<PedidoResgate>, IPedidoResgateServices
    {
        protected new readonly IPedidoResgateRepository _repository;

        public PedidoResgateServices(IPedidoResgateRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
