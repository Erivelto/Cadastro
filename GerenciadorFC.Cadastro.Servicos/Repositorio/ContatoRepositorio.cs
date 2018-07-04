using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.EntityFrameworkCore;
using Dapper;


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
		public Contato ObterPorUserId(string userId)
		{
			return ctx.Set<Contato>().Where(x => x.UserId == userId && x.Excluido == false).FirstOrDefault();
		}
		public List<Contato> ObterLista(int codigo)
		{
			return ctx.Set<Contato>().Where(c => c.Excluido == false && c.CodigoRepLegal == codigo).ToList();
		}
		public Contato ObterPorCodigo(int codigo)
		{
			return ctx.Set<Contato>().Where(x => x.Codigo == codigo && x.Excluido == false).FirstOrDefault();
		}
		public string ConsultaStatus(int CodigoPessoa)
		{
			using (IDbConnection db = new SqlConnection(@"Server=tcp:gerenciadorbilhetagem.database.windows.net,1433;Initial Catalog=dbCadastro; Uid=fabioesimoes; Pwd=q1w2e3r4@;"))
			{
				string select = "SELECT TOP (1) [Status]  FROM [dbo].[AspNetUsers]  where CodigoPessoa = @CodigoPessoa";

				var result = db.ExecuteScalar(select, new
				{
					CodigoPessoa
				});
				return result.ToString();
			}
		}
		public bool AtualizaStatus(int codigo)
		{
			var status = ConsultaStatus(codigo);
			bool up = false;
			if (status != "")
			{
				if (status == "ativo")
				{
					status = "pagamentoandamento";
				}
				else
				{
					status = "ativo";
				}
				using (IDbConnection db = new SqlConnection(@"Server=tcp:gerenciadorbilhetagem.database.windows.net,1433;Initial Catalog=dbCadastro; Uid=fabioesimoes; Pwd=q1w2e3r4@;"))
				{
					string update = "UPDATE [dbo].[AspNetUsers]   SET [Status] = @status WHERE CodigoPessoa = @codigo";

					var result = db.Execute(update, new
					{
						status,
						codigo
					});
					up = true;
				}				
			}
			return up;
		}

	}
}
