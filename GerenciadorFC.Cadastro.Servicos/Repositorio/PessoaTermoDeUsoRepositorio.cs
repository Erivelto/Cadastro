using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class PessoaTermoDeUsoRepositorio
    {
		Contexto ctx = new Contexto();
		public PessoaTermoDeUso Adicionar(PessoaTermoDeUso pessoaTermoDeUso)
		{
			ctx.PessoaTermoDeUso.Add(pessoaTermoDeUso);
			ctx.SaveChanges();
			return pessoaTermoDeUso;
		}
		public PessoaTermoDeUso ObterPorCodigo(int codigo)
		{
			return ctx.Set<PessoaTermoDeUso>().Where(x => x.Codigo == codigo).FirstOrDefault();
		}
	}
}
