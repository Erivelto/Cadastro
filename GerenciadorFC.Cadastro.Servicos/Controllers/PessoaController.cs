using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Route("api/Pessoa")]
    public class PessoaController : Controller
    {
		Repositorio.PessoaRepositorio _repositorio = new Repositorio.PessoaRepositorio();
		[HttpPost]
		public Pessoa Post([FromBody]Pessoa pessoa)
		{
			_repositorio.Adicionar(pessoa);
			return  pessoa;
		}
		[HttpPut]
		public Pessoa Put([FromBody]Pessoa pessoa)
		{
			_repositorio.Atualizar(pessoa);
			return pessoa;
		}
		[HttpGet("{codigo}")]
		public Pessoa Get(int codigo)
		{
			return _repositorio.ObterPorCodigo(codigo);			
		}
		[HttpGet]
		public List<Pessoa> Get()
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