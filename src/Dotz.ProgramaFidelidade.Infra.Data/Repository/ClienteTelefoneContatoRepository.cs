using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;
using Dotz.ProgramaFidelidade.Infra.Data.Context;

namespace Dotz.ProgramaFidelidade.Infra.Data.Repository
{
    public class ClienteTelefoneContatoRepository : RepositoryBase<ClienteTelefoneContato>, IClienteTelefoneContatoRepository
    {
        protected new readonly DotzContext db;

        public ClienteTelefoneContatoRepository(DotzContext _db) : base(_db)
        {
            db = _db;
        }
    }
}