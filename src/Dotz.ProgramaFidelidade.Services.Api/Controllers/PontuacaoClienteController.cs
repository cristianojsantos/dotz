using Dotz.ProgramaFidelidade.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotz.ProgramaFidelidade.Services.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PontuacaoClienteController : Controller
    {
        private readonly ILogger<PontuacaoClienteController> _logger;
        protected readonly IPontuacaoClienteServices _pontuacaoCliente;

        public PontuacaoClienteController(ILogger<PontuacaoClienteController> logger, IPontuacaoClienteServices pontuacaoCliente)
        {
            _logger = logger;
            _pontuacaoCliente = pontuacaoCliente;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
