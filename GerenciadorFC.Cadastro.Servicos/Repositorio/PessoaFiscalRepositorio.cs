using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class PessoaFiscalRepositorio
    {
        Contexto ctx = new Contexto();
        public PessoaFiscal Adicionar(PessoaFiscal pessoaFiscal)
        {
            ctx.PessoaFiscals.Add(pessoaFiscal);
            ctx.SaveChanges();
            return pessoaFiscal;
        }
        public PessoaFiscal Atualizar(PessoaFiscal pessoaFiscal)
        {
            ctx.Entry(pessoaFiscal).State = EntityState.Modified;
            ctx.SaveChanges();
            return pessoaFiscal;
        }
        public List<PessoaFiscal> ObterLista()
        {
            return ctx.Set<PessoaFiscal>().Where(x => x.Excluido == false).ToList();
        }
        public PessoaFiscal ObterPorCodigo(int codigo)
        {
            return ctx.Set<PessoaFiscal>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
        }
		public bool Excluir(int codigo)
		{
			var remove = ctx.PessoaFiscals.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
	}
}
