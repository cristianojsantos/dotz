using Dotz.ProgramaFidelidade.Domain.Models.ClienteContext;
using System.Collections.Generic;

namespace Dotz.ProgramaFidelidade.Domain.Models
{
    public class TipoEndereco
    {
        public TipoEndereco(int codigoTipoEndereco, string descricaoTipoEndereco)
        {
            CodigoTipoEndereco = codigoTipoEndereco;
            DescricaoTipoEndereco = descricaoTipoEndereco;

            ClienteEndereco = new List<ClienteEndereco>();
        }

        public int CodigoTipoEndereco { get; private set; }
        public string DescricaoTipoEndereco { get; private set; }

        public virtual ICollection<ClienteEndereco> ClienteEndereco { get; set; }

        public override string ToString()
        {
            return DescricaoTipoEndereco.ToString().ToUpper();
        }
    }
}
