using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Produces("application/json")]
    [Route("api/PessoaTermoDeUso")]
    public class PessoaTermoDeUsoController : Controller
    {
		Repositorio.PessoaTermoDeUsoRepositorio _repositorio = new Repositorio.PessoaTermoDeUsoRepositorio();
		[HttpPost]
		public PessoaTermoDeUso Post([FromBody]PessoaTermoDeUso pessoaTermoDeUso)
		{
			_repositorio.Adicionar(pessoaTermoDeUso);
			return pessoaTermoDeUso;
		}
		[HttpGet("{codigo}")]
		public PessoaTermoDeUso Get(int codigo)
		{
			return _repositorio.ObterPorCodigo(codigo);
		}
		[HttpGet("UserID/{id}")]
		public PessoaTermoDeUso Get(string id)
		{
			return _repositorio.ObterPorCodigoIdUser(id);
		}

	}
}