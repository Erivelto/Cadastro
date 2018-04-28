using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class NotificacaoPagamento
    {
		public Guid codigo { get; set; }
		public string notificationCode { get; set; }
		public string notificationType { get; set; }
		public int codigoPessoa { get; set; }
		public DateTime Data { get; set; }
	}
}
