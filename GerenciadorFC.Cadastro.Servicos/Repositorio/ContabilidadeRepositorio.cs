using System;
using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class ContabilidadeRepositorio
    {
		Contexto ctx = new Contexto();
		public Contabilidade Adicionar(Contabilidade contabilidade)
		{
			ctx.Contabilidades.Add(contabilidade);
			ctx.SaveChanges();
			return contabilidade;
		}
		public bool Excluir(int codigo)
		{
			var remove = ctx.Contabilidades.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
		public Contabilidade Atualizar(Contabilidade contabilidade)
		{
			ctx.Entry(contabilidade).State = EntityState.Modified;
			ctx.SaveChanges();
			return contabilidade;
		}
		public List<Contabilidade> ObterLista()
		{
			return ctx.Set<Contabilidade>().Where(c => c.Excluido == false).ToList();
		}
		public Contabilidade ObterPorCodigo(int codigo)
		{
			return ctx.Set<Contabilidade>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
		}
	}
}
