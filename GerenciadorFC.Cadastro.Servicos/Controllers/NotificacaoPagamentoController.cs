using Microsoft.AspNetCore.Mvc;
using GerenciadorFC.Cadastro.Dominio.Implementacao;
using System;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
	[Produces("application/json")]
    [Route("api/NotificacaoPagamento")]
    public class NotificacaoPagamentoController : Controller
    {
		Repositorio.NotificacaoPagamentoRepositorio _repositorio = new Repositorio.NotificacaoPagamentoRepositorio();
		// POST: api/NotificacaoPagamento
		[HttpPost]
        public void Post(string notificationCode, string notificationType)
        {
			var notificacao = new NotificacaoPagamento();
			notificacao.notificationCode = notificationCode;
			notificacao.notificationType = notificationType;
			notificacao.Data = DateTime.Now;
			_repositorio.Adicionar(notificacao);
        }      
    }
}
