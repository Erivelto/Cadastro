using GerenciadorFC.Cadastro.Dominio.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class PessoaValidaRepositorio
    {
		Contexto ctx = new Contexto();
		public PessoaValida Obter(int codigoRep)
		{
			var valida = new PessoaValida();
			var representanteLegal = ctx.Set<RepresentanteLegal>().Where(p => p.Codigo == codigoRep).FirstOrDefault();
			var pessoa = ctx.Set<Pessoa>().Where(p => p.Codigo == representanteLegal.CodigoPessoa).FirstOrDefault();
			var termo = ctx.Set<PessoaTermoDeUso>().Where(p => p.CodigoPessoa == pessoa.Codigo).FirstOrDefault();
			var pessoCob = ctx.Set<PessoaCobranca>().Where(p => p.Reference == pessoa.Documento).FirstOrDefault();

			return valida;
		}
	}
}
