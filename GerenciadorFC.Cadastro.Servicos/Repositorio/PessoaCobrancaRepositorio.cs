using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class PessoaCobrancaRepositorio
    {
		Contexto ctx = new Contexto();
		public PessoaCobranca Adicionar(PessoaCobranca pessoaCobranca)
		{
			ctx.PessoaCobranca.Add(pessoaCobranca);
			ctx.SaveChanges();
			return pessoaCobranca;
		}
		public PessoaCobranca Atualizar(PessoaCobranca pessoaCobranca)
		{
			ctx.Entry(pessoaCobranca).State = EntityState.Modified;
			ctx.SaveChanges();
			return pessoaCobranca;
		}
		public List<PessoaCobranca> ObterLista()
		{
			return ctx.Set<PessoaCobranca>().ToList();
		}
		public PessoaCobranca ObterPorCodigo(string transacao)
		{
			return ctx.Set<PessoaCobranca>().Where(x => x.Transacao == transacao).FirstOrDefault();
		}
	}
}
