using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class PessoaFiscalHistorico
    {
		public int Codigo { get; set; }
		public int MesReferencia { get; set; }
		public DateTime DataGeracaoDAS { get; set; }
		public bool EnviadoCliente { get; set; }
	}
}
