using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class PessoaLoginRepositorio
    {
        Contexto ctx = new Contexto();
        public PessoaLogin Adicionar(PessoaLogin pessoaLogin)
        {
            ctx.PessoaLogins.Add(pessoaLogin);
            ctx.SaveChanges();
            return pessoaLogin;
        }
        public PessoaLogin Atualizar(PessoaLogin pessoaLogin)
        {
            ctx.Entry(pessoaLogin).State = EntityState.Modified;
            ctx.SaveChanges();
            return pessoaLogin;
        }
        public List<PessoaLogin> ObterLista()
        {
            return ctx.Set<PessoaLogin>().Where(x => x.Excluido == false).ToList();
        }
        public PessoaLogin ObterPorCodigo(int codigo)
        {
            return ctx.Set<PessoaLogin>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
        }
		public bool Excluir(int codigo)
		{
			var remove = ctx.PessoaLogins.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
	}
}
