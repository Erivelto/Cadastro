using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class Contabilidade
    {
		public int Codigo { get; set; }
		public string Nome { get; set; }
		public string Razao { get; set; }
		public string Documento { get; set; }
		public string InscricaoMunicipal { get; set; }
		public string InscricaoEstadual { get; set; }
		public DateTime DataInclusao { get; set; }
		public DateTime DataAtulizacao { get; set; }
		public int Status { get; set; }
		public string Registro { get; set; }
		public bool Excluido { get; set; }
	}
}
