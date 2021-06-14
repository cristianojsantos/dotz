using Dotz.ProgramaFidelidade.Application.Interface;
using Dotz.ProgramaFidelidade.Domain.Interface;
using Dotz.ProgramaFidelidade.Domain.Models;

namespace Dotz.ProgramaFidelidade.Application.Services
{
    public class TipoTelefoneContatoServices : ServiceBase<TipoTelefoneContato>, ITipoTelefoneContatoServices
    {
        protected new readonly ITipoTelefoneContatoRepository _repository;

        public TipoTelefoneContatoServices(ITipoTelefoneContatoRepository repository) : base(repository)
        {
        }
    }
}
