using System;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class PessoaTermoDeUso
    {
		public int Codigo { get; set; }
		public int CodigoPessoa { get; set; }
		public DateTime DataTermo { get; set; }
		public string UserId { get; set; }
	}
}
