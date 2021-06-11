using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;
using Dotz.ProgramaFidelidade.Infra.Data.Context;

namespace Dotz.ProgramaFidelidade.Infra.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        protected new readonly DotzContext db;

        public ClienteRepository(DotzContext _db) : base(_db)
        {
            db = _db;
        }
    }
}