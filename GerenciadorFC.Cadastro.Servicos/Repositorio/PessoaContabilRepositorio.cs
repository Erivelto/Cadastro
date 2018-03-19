using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class PessoaContabilRepositorio
    {
		Contexto ctx = new Contexto();
		public PessoaContabil Adicionar(PessoaContabil pessoaContabil)
		{
			ctx.PessoaContabils.Add(pessoaContabil);
			ctx.SaveChanges();
			return pessoaContabil;
		}
		public PessoaContabil Atualizar(PessoaContabil pessoaContabil)
		{
			ctx.Entry(pessoaContabil).State = EntityState.Modified;
			ctx.SaveChanges();
			return pessoaContabil;
		}
		public List<PessoaContabil> ObterLista()
		{
			return ctx.Set<PessoaContabil>().Where(x => x.Excluido == false).ToList();
		}
		public PessoaContabil ObterPorCodigo(int codigo)
		{
			return ctx.Set<PessoaContabil>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
		}
		public bool Excluir(int codigo)
		{
			var remove = ctx.PessoaContabils.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
	}
}
