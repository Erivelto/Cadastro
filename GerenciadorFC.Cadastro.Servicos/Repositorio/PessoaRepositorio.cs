using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class PessoaRepositorio
    {
		Contexto ctx = new Contexto();
		public Pessoa Adicionar(Pessoa pessoa)
		{
			ctx.Pessoas.Add(pessoa);
			ctx.SaveChanges();
			return pessoa;
		}
		public Pessoa Atualizar(Pessoa pessoa)
		{
			ctx.Entry(pessoa).State = EntityState.Modified;
			ctx.SaveChanges();
			return pessoa;
		}
		public List<Pessoa> ObterLista()
		{
			return ctx.Set<Pessoa>().Where(x => x.Excluido == false).ToList();
		}
		public Pessoa ObterPorCodigo(int codigo)
		{
			return ctx.Set<Pessoa>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
		}
		public bool Excluir(int codigo)
		{
			var remove = ctx.Pessoas.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
	}
}
