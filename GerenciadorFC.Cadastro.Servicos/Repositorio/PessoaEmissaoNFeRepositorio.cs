using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class PessoaEmissaoNFeRepositorio
    {
		Contexto ctx = new Contexto();
		public PessoaEmissaoNFe Adicionar(PessoaEmissaoNFe pessoaEmissaoNFe)
		{
			ctx.PessoaEmissaoNFe.Add(pessoaEmissaoNFe);
			ctx.SaveChanges();
			return pessoaEmissaoNFe;
		}
		public bool Excluir(int codigo)
		{
			var remove = ctx.PessoaEmissaoNFe.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
		public PessoaEmissaoNFe Atualizar(PessoaEmissaoNFe pessoaEmissaoNFe)
		{
			ctx.Entry(pessoaEmissaoNFe).State = EntityState.Modified;
			ctx.SaveChanges();
			return pessoaEmissaoNFe;
		}
		public List<PessoaEmissaoNFe> ObterLista()
		{
			return ctx.Set<PessoaEmissaoNFe>().Where(c => c.Excluido == false).ToList();
		}
		public PessoaEmissaoNFe ObterPorCodigo(int codigo)
		{
			return ctx.Set<PessoaEmissaoNFe>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
		}
	}
}
