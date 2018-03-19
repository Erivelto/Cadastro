using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class PessoaFiscal
    {
		public int Codigo { get; set; }
		public int CodigoPessoa { get; set; }
		public string CodigoFiscal { get; set; }
		public string TipoEmpresa { get; set; }
		public string AnexoFiscal { get; set; }
		public bool Excluido { get; set; }
	}
}
