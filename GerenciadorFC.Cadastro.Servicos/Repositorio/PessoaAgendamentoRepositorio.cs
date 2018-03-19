using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class PessoaAgendamentoRepositorio
    {
		Contexto ctx = new Contexto();
		public PessoaAgendamento Adicionar(PessoaAgendamento pessoaAgendamento)
		{
			ctx.PessoaAgendamentos.Add(pessoaAgendamento);
			ctx.SaveChanges();
			return pessoaAgendamento;
		}
		public PessoaAgendamento Atualizar(PessoaAgendamento pessoaAgendamento)
		{
			ctx.Entry(pessoaAgendamento).State = EntityState.Modified;
			ctx.SaveChanges();
			return pessoaAgendamento;
		}
		public List<PessoaAgendamento> ObterLista()
		{
			return ctx.Set<PessoaAgendamento>().Where(x => x.Excluido == false).ToList();
		}
		public PessoaAgendamento ObterPorCodigo(int codigo)
		{
			return ctx.Set<PessoaAgendamento>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
		}
		public bool Excluir(int codigo)
		{
			var remove = ctx.PessoaAgendamentos.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
	}
}
