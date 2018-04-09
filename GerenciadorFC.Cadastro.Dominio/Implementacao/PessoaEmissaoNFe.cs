using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class PessoaEmissaoNFe
    {
		public int Codigo { get; set; }
		public int CodigoPessoa { get; set; }
		public string senha { get; set; }
		public string prefeitura { get; set; }
		public string urlPrefeitura { get; set; }
		public List<PessoaCodigoServico> PessoaCodigoServico { get; set; }
		public List<DadosNota> dadosNota { get; set; }
		public bool Excluido { get; set; }
	}
}
