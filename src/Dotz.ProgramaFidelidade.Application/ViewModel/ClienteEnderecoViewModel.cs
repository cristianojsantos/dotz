using System;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class ClienteEnderecoViewModel
    {
        public ClienteEnderecoViewModel()
        {

        }

        public Guid CodigoCliente { get; private set; }
        public int CodigoTipoEndereco { get; private set; }
        public string Logradouro { get; private set; }
        public string NumeroEnderco { get; private set; }
        public string Complemento { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Longitude { get; private set; }
        public string Latitude { get; private set; }
        public string CodigoIBGE { get; private set; }

        public virtual ClienteViewModel Cliente { get; set; }
        public virtual TipoEnderecoViewModel TipoEndereco { get; set; }

        public override string ToString()
        {
            return $"{Logradouro}, {NumeroEnderco}, {Complemento}, {Cep}, {Bairro}, {Cidade}, {UF}".ToUpper();
        }
    }
}
