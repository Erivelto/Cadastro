using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class RepresentanteLegalRepositorio
    {
        Contexto ctx = new Contexto();
        public RepresentanteLegal Adicionar(RepresentanteLegal representanteLegal)
        {
            ctx.RepresentanteLegals.Add(representanteLegal);
            ctx.SaveChanges();
            return representanteLegal;
        }
        public RepresentanteLegal Atualizar(RepresentanteLegal representanteLegal)
        {
            ctx.Entry(representanteLegal).State = EntityState.Modified;
            ctx.SaveChanges();
            return representanteLegal;
        }
        public List<RepresentanteLegal> ObterLista()
        {
            return ctx.Set<RepresentanteLegal>().Where(x => x.Excluido == false).ToList();
        }
        public RepresentanteLegal ObterPorCodigo(int codigo)
        {
            return ctx.Set<RepresentanteLegal>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
        }
		public bool Excluir(int codigo)
		{
			var remove = ctx.RepresentanteLegals.Where(c => c.Codigo == codigo).FirstOrDefault();
			remove.Excluido = true;
			ctx.Entry(remove).State = EntityState.Modified;
			ctx.SaveChanges();
			return true;
		}
	}
}
