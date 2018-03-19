using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class PessoaAgendamento
    {
		public int Codigo { get; set; }
		public int CodigoPessoa { get; set; }
		public int DiaFaturamento { get; set; }
		public int DiaImposto { get; set; }
		public string CodigoFiscal { get; set; }
		public bool Excluido { get; set; }
	}
}
