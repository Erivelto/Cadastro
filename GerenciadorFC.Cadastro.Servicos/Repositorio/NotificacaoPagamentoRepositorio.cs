using GerenciadorFC.Cadastro.Dominio.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class NotificacaoPagamentoRepositorio
    {
		Contexto ctx = new Contexto();
		public NotificacaoPagamento Adicionar(NotificacaoPagamento notificacaoPagamento)
		{
			ctx.NotificacaoPagamento.Add(notificacaoPagamento);
			ctx.SaveChanges();
			return notificacaoPagamento;
		}
	}
}
