using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.PedidoContext;
using Dotz.ProgramaFidelidade.Infra.Data.Context;

namespace Dotz.ProgramaFidelidade.Infra.Data.Repository
{
    public class PedidoResgateItemRepository : RepositoryBase<PedidoResgateItem>, IPedidoResgateItemRepository
    {
        protected new readonly DotzContext db;

        public PedidoResgateItemRepository(DotzContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
