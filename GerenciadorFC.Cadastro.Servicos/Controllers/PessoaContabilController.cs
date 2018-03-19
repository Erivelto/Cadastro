using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
   [Route("api/PessoaContabil")]
    public class PessoaContabilController : Controller
    {
		// GET: api/PessoaContabil
		Repositorio.PessoaContabilRepositorio _repositorio = new Repositorio.PessoaContabilRepositorio();
		[HttpPost]
		public PessoaContabil Post([FromBody]PessoaContabil pessoaContabil)
		{
			_repositorio.Adicionar(pessoaContabil);
			return pessoaContabil;
		}
		[HttpPut]
		public PessoaContabil Put([FromBody]PessoaContabil pessoaContabil)
		{
			_repositorio.Atualizar(pessoaContabil);
			return pessoaContabil;
		}
		[HttpGet("{codigo}")]
		public PessoaContabil Get(int codigo)
		{
			return _repositorio.ObterPorCodigo(codigo);
		}
		[HttpGet]
		public List<PessoaContabil> Get()
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
