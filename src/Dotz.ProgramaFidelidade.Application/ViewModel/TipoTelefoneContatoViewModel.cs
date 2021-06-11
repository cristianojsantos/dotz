namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class TipoTelefoneContatoViewModel
    {
        public TipoTelefoneContatoViewModel()
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
