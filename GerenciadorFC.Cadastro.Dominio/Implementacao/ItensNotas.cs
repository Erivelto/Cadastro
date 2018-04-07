using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class ItensNotas
    {
		public int Codigo { get; set; }
		public int Quantidade { get; set; }
		public string Descricao { get; set; }
		public decimal ValorUni { get; set; }
		public bool Excluido { get; set; }
	}
}
