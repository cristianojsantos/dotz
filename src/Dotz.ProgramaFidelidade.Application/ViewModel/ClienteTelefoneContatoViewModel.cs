using System;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class ClienteTelefoneContatoViewModel
    {
        public ClienteTelefoneContatoViewModel(Guid codigoCliente, int codigoTipoContato, int numeroDDD, int numeroTelefone)
        {
            CodigoCliente = codigoCliente;
            CodigoTipoContato = codigoTipoContato;
            NumeroDDD = numeroDDD;
            NumeroTelefone = numeroTelefone;
        }

        public Guid CodigoCliente { get; private set; }
        public int CodigoTipoContato { get; private set; }
        public int NumeroDDD { get; private set; }
        public int NumeroTelefone { get; private set; }

        public virtual ClienteViewModel Cliente { get; set; }
        public virtual TipoTelefoneContatoViewModel TipoTelefoneContato { get; set; }
    }
}
