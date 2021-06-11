using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models;
using Dotz.ProgramaFidelidade.Infra.Data.Context;

namespace Dotz.ProgramaFidelidade.Infra.Data.Repository
{
    public class TipoEnderecoRepository : RepositoryBase<TipoEndereco>, ITipoEnderecoRepository
    {
        protected new readonly DotzContext db;

        public TipoEnderecoRepository(DotzContext _db) : base(_db)
        {
            db = _db;
        }
    }
}