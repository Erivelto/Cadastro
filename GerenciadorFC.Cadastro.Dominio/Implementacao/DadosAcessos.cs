using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class DadosAcessos
    {
		public int Codigo { get; set; }
		public int CodigoPrefeitura { get; set; }
		public int CodigoReceita { get; set; }
		public string UrlPrefeitura { get; set; }
		public string UrlReceita { get; set; }
		public string CodigoAntiCaptcha { get; set; }
		public int Excluido { get; set; }
	}
}
