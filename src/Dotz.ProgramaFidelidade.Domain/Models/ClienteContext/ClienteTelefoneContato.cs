using System;

namespace Dotz.ProgramaFidelidade.Domain.Models.ClienteContext
{
    public class ClienteTelefoneContato
    {
        public ClienteTelefoneContato(Guid codigoCliente, int codigoTipoContato, int numeroDDD, int numeroTelefone)
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

        public virtual Cliente Cliente { get; set; }
        public virtual TipoTelefoneContato TipoTelefoneContato { get; set; }
    }
}
