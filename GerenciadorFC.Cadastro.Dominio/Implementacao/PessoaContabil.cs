using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class PessoaContabil
    {
		public int Codigo { get; set; }
		public int CodigoContabil { get; set; }
		public int CodigoPessoa { get; set; }
		public bool Excluido { get; set; }
	}
}
