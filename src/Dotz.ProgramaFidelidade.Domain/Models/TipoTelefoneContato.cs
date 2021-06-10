namespace Dotz.ProgramaFidelidade.Domain.Models
{
    public class TipoTelefoneContato
    {
        public TipoTelefoneContato()
        {

        }

        public int CodigoTipoTelefoneContato { get; private set; }
        public string DescricaoTipoTelefoneContato { get; private set; }

        public override string ToString()
        {
            return DescricaoTipoTelefoneContato.ToUpper().Trim();
        }
    }
}
