using System;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class PontuacaoClienteViewModel
    {
        public PontuacaoClienteViewModel()
        {
            
        }

        public Guid CodigoCliente { get; private set; }
        public Guid CodigoLancamento { get; private set; }
        public DateTime DataLancamento { get; private set; }
        public DateTime DataExpiracaoPontos { get; private set; }
        public decimal ValorPontuacao { get; private set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}
