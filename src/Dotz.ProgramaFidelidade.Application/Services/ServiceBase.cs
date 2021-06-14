using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class ServiceBase<TEntity>: IServiceBase<TEntity> where TEntity: class
    {
        protected readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }
    }
}
