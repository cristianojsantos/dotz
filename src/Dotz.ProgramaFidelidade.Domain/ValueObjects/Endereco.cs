namespace Dotz.ProgramaFidelidade.Domain.ValueObjects
{
    public class Endereco
    {
        public Endereco()
        {

        }

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

        public override string ToString()
        {
            return $"{Logradouro}, {NumeroEnderco}, {Complemento}, {Cep}, {Bairro}, {Cidade}, {UF}".ToUpper();
        }
    }
}
