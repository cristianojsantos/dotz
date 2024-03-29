﻿using System.Collections.Generic;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class TipoEnderecoViewModel
    {
        public TipoEnderecoViewModel()
        {
            ClienteEndereco = new List<ClienteEnderecoViewModel>();
        }

        public int CodigoTipoEndereco { get; private set; }
        public string DescricaoTipoEndereco { get; private set; }

        public virtual ICollection<ClienteEnderecoViewModel> ClienteEndereco { get; set; }

        public override string ToString()
        {
            return DescricaoTipoEndereco.ToString().ToUpper();
        }
    }
}
