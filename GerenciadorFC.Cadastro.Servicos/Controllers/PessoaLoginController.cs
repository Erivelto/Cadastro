using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Route("api/PessoaLogin")]
    public class PessoaLoginController : Controller
    {
        Repositorio.PessoaLoginRepositorio _repositorio = new Repositorio.PessoaLoginRepositorio();
        [HttpPost]
        public PessoaLogin Post([FromBody]PessoaLogin pessoaLogin)
        {
            _repositorio.Adicionar(pessoaLogin);
            return pessoaLogin;
        }
        [HttpPut]
        public PessoaLogin Put([FromBody]PessoaLogin pessoaLogin)
        {
            _repositorio.Atualizar(pessoaLogin);
            return pessoaLogin;
        }
        [HttpGet("{codigo}")]
        public PessoaLogin Get(int codigo)
        {
            return _repositorio.ObterPorCodigo(codigo);
        }
        [HttpGet]
        public List<PessoaLogin> Get()
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
