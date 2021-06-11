using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models;
using Dotz.ProgramaFidelidade.Infra.Data.Context;

namespace Dotz.ProgramaFidelidade.Infra.Data.Repository
{
    public class TipoTelefoneContatoRepository : RepositoryBase<TipoTelefoneContato>, ITipoTelefoneContatoRepository
    {
        protected new readonly DotzContext db;

        public TipoTelefoneContatoRepository(DotzContext _db) : base(_db)
        {
            db = _db;
        }
    }
}