using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.PontuacaoContext;
using Dotz.ProgramaFidelidade.Infra.Data.Context;

namespace Dotz.ProgramaFidelidade.Infra.Data.Repository
{
    public class PontuacaoClienteRepository : RepositoryBase<PontuacaoCliente>, IPontuacaoClienteRepository
    {
        protected new readonly DotzContext db;

        public PontuacaoClienteRepository(DotzContext _db) : base(_db)
        {
            db = _db;
        }
    }
}
