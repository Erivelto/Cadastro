using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.EntityFrameworkCore;


namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class ContatoRepositorio
    {
		Contexto ctx = new Contexto();
		public Contato Adicionar(Contato contato)
		{
			ctx.Contatos.Add(contato);
			ctx.SaveChanges();
			return contato;
		}
		public Contato Atualizar(Contato contato)
		{
			ctx.Entry(contato).State = EntityState.Modified;
			ctx.SaveChanges();
			return contato;
		}
		public bool Excluir(int codigo)
		{
			var remove = ctx.Contatos.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
		public List<Contato> ObterLista()
		{
			return ctx.Set<Contato>().Where(c => c.Excluido == false).ToList();
		}
		public Contato ObterPorCodigo(int codigo)
		{
			return ctx.Set<Contato>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
		}
	}
}
