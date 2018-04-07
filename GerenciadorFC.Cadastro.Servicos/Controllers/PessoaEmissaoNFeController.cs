using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Route("api/PessoaEmissaoNFe")]
    public class PessoaEmissaoNFeController : Controller
    {
		Repositorio.PessoaEmissaoNFeRepositorio _repositorio = new Repositorio.PessoaEmissaoNFeRepositorio();
		[HttpPost]
		public PessoaEmissaoNFe Post([FromBody]PessoaEmissaoNFe pessoa)
		{
			_repositorio.Adicionar(pessoa);
			return pessoa;
		}
		[HttpPut]
		public PessoaEmissaoNFe Put([FromBody]PessoaEmissaoNFe pessoa)
		{
			_repositorio.Atualizar(pessoa);
			return pessoa;
		}
		[HttpGet("{codigo}")]
		public PessoaEmissaoNFe Get(int codigo)
		{
			return _repositorio.ObterPorCodigo(codigo);
		}
		[HttpGet]
		public List<PessoaEmissaoNFe> Get()
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