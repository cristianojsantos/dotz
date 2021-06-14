using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.PedidoContext;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class PedidoResgateItemServices : ServiceBase<PedidoResgateItem>, IPedidoResgateItemServices
    {
        protected new readonly IPedidoResgateItemRepository _repository;

        public PedidoResgateItemServices(IPedidoResgateItemRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
