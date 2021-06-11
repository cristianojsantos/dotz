﻿using System;

namespace Dotz.ProgramaFidelidade.Application.ViewModel
{
    public class ClienteViewModel
    {
        public ClienteViewModel(Guid codigoCliente, string nomeCliente, string numeroCPF, string numeroRG, DateTime dataNascimento, DateTime dataCadastro, DateTime dataAtualizacao)
        {
            CodigoCliente = codigoCliente;
            NomeCliente = nomeCliente;
            NumeroCPF = numeroCPF;
            NumeroRG = numeroRG;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            DataAtualizacao = dataAtualizacao;
        }

        public Guid CodigoCliente { get; private set; }
        public string NomeCliente { get; private set; }
        public string NumeroCPF { get; private set; }
        public string NumeroRG { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }
        public bool CadastroAtivo { get; private set; }

        public override string ToString()
        {
            return NomeCliente.ToUpper().Trim();
        }
    }
}
