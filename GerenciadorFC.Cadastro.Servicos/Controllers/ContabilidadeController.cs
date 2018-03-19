using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Route("api/Contabilidade")]
    public class ContabilidadeController : Controller
    {
		// GET: api/Contabilidade
		Repositorio.ContabilidadeRepositorio _repositorio = new Repositorio.ContabilidadeRepositorio();
		[HttpPost]
		public Contabilidade Post([FromBody]Contabilidade contabilidade)
		{
			_repositorio.Adicionar(contabilidade);
			return contabilidade;
		}
		[HttpPut]
		public Contabilidade Put([FromBody]Contabilidade contabilidade)
		{
			_repositorio.Atualizar(contabilidade);
			return contabilidade;
		}
		[HttpGet("{codigo}")]
		public Contabilidade Get(int codigo)
		{
			return _repositorio.ObterPorCodigo(codigo);
		}
		[HttpGet]
		public List<Contabilidade> Get()
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
