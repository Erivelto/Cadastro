using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Route("api/PessoaAgendamento")]
    public class PessoaAgendamentoController : Controller
    {
		// GET: api/Contabilidade
		Repositorio.PessoaAgendamentoRepositorio _repositorio = new Repositorio.PessoaAgendamentoRepositorio();
		[HttpPost]
		public PessoaAgendamento Post([FromBody]PessoaAgendamento pessoaAgendamento)
		{
			_repositorio.Adicionar(pessoaAgendamento);
			return pessoaAgendamento;
		}
		[HttpPut]
		public PessoaAgendamento Put([FromBody]PessoaAgendamento pessoaAgendamento)
		{
			_repositorio.Atualizar(pessoaAgendamento);
			return pessoaAgendamento;
		}
		[HttpGet("{codigo}")]
		public PessoaAgendamento Get(int codigo)
		{
			return _repositorio.ObterPorCodigo(codigo);
		}
		[HttpGet]
		public List<PessoaAgendamento> Get()
		{
			return _repositorio.ObterLista();
		}
		[HttpDelete]
		public bool Delete(int codigo)
		{
			return _repositorio.Excluir(codigo);
		}
	}
}
