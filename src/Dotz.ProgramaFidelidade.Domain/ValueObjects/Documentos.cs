namespace Dotz.ProgramaFidelidade.Domain.ValueObjects
{
    public class Documentos
    {
        public Documentos()
        {

        }

        public string NumeroCPF { get; private set; }
        public string NumeroRG { get; private set; }

        public override string ToString()
        {
            return NumeroCPF.ToUpper().Trim();
        }
    }
}
