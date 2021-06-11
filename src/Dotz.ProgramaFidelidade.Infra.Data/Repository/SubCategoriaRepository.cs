using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models.ProdutoContext;
using Dotz.ProgramaFidelidade.Infra.Data.Context;

namespace Dotz.ProgramaFidelidade.Infra.Data.Repository
{
    public class SubCategoriaRepository : RepositoryBase<SubCategoria>, ISubCategoriaRepository
    {
        protected new readonly DotzContext db;

        public SubCategoriaRepository(DotzContext _db) : base(_db)
        {
            db = _db;
        }
    }
}