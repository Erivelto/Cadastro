using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class DadosNota
    {
		public int Codigo { get; set; }
		public DateTime DataEnvio { get; set; }
		public decimal ValorTotal { get; set; }		
		public int  NumeroNFE{ get; set; }
		public DateTime DataEmissao { get; set; }
		public string CodigoVerificacao { get; set; }
		public List<ItensNotas> itensNotas { get; set; }
		public bool Excluido { get; set; }
	}
}
