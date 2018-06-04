using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class PessoaCobranca
    {
		public int Codigo { get; set; }
		public string Reference { get; set; }
		public string CodePrepoval { get; set; } 
		public string Transacao { get; set; }
		public DateTime DataTransacao { get; set; }
		public DateTime DataPagamento { get; set; }
		public string Status { get; set; }
    }
}
