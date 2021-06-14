using System;

namespace Dotz.ProgramaFidelidade.Domain.Models.ClienteContext
{
    public class ClienteEndereco
    {
        public ClienteEndereco(Guid codigoCliente,
                               int codigoTipoEndereco,
                               string logradouro,
                               string numeroEndereco,
                               string complemento,
                               string cep,
                               string bairro,
                               string cidade,
                               string uf,
                               string longitude,
                               string latitude,
                               string codigoIBGE)
        {
            CodigoCliente = codigoCliente;
            CodigoTipoEndereco = CodigoTipoEndereco;
            Logradouro = logradouro;
            NumeroEndereco = numeroEndereco;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Longitude = longitude;
            Latitude = latitude;
            CodigoIBGE = codigoIBGE;
        }

        public Guid CodigoCliente { get; private set; }
        public int CodigoTipoEndereco { get; private set; }
        public string Logradouro { get; private set; }
        public string NumeroEndereco { get; private set; }
        public string Complemento { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Longitude { get; private set; }
        public string Latitude { get; private set; }
        public string CodigoIBGE { get; private set; }

        public virtual Cliente Cliente { get; set; }
        public virtual TipoEndereco TipoEndereco { get; set; }

        public override string ToString()
        {
            return $"{Logradouro}, {NumeroEndereco}, {Complemento}, {Cep}, {Bairro}, {Cidade}, {UF}".ToUpper();
        }        
    }
}
