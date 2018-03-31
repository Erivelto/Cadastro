using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
	//[Authorize]
    [Route("api/Endereco")]
    public class EnderecoController : Controller
    {
		// GET: api/Endereco
		// GET: api/Contabilidade
		Repositorio.EnderecoRepositorio _repositorio = new Repositorio.EnderecoRepositorio();
		[HttpPost]
		public Endereco Post([FromBody]Endereco endereco)
		{
			_repositorio.Adicionar(endereco);
			return endereco;
		}
		[HttpPut]
		public Endereco Put([FromBody]Endereco endereco)
		{
			_repositorio.Atualizar(endereco);
			return endereco;
		}
		[HttpGet("{codigo}")]
		public Endereco Get(int codigo)
		{
			return _repositorio.ObterPorCodigo(codigo);
		}
		[HttpGet]
		public List<Endereco> Get()
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
