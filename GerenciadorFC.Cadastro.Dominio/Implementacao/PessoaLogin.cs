using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class PessoaLogin
    {
		public int Codigo { get; set; }
		public int CodigoPessoa { get; set; }
		public int TipoLogin { get; set; }
		public DateTime DataInclusao { get; set; }
		public DateTime DataUltimoAcesso { get; set; }
		public bool Excluido { get; set; }
	}
}
