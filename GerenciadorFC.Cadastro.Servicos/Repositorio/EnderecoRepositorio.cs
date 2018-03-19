using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class EnderecoRepositorio
    {
		Contexto ctx = new Contexto();
		public Endereco Adicionar(Endereco endereco)
		{
			ctx.Enderecos.Add(endereco);
			ctx.SaveChanges();
			return endereco;
		}
		public Endereco Atualizar(Endereco endereco)
		{
			ctx.Entry(endereco).State = EntityState.Modified;
			ctx.SaveChanges();
			return endereco;
		}
		public List<Endereco> ObterLista()
		{
			return ctx.Set<Endereco>().Where(x => x.Excluido == false).ToList();
		}
		public Endereco ObterPorCodigo(int codigo)
		{
			return ctx.Set<Endereco>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
		}

		public bool Excluir(int codigo)
		{
			var remove = ctx.Enderecos.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
	}
}
