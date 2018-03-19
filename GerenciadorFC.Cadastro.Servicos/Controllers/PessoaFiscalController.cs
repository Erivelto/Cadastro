using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Route("api/PessoaFiscal")]
    public class PessoaFiscalController : Controller
    {
        Repositorio.PessoaFiscalRepositorio _repositorio = new Repositorio.PessoaFiscalRepositorio();
        [HttpPost]
        public PessoaFiscal Post([FromBody]PessoaFiscal pessoaFiscal)
        {
            _repositorio.Adicionar(pessoaFiscal);
            return pessoaFiscal;
        }
        [HttpPut]
        public PessoaFiscal Put([FromBody]PessoaFiscal pessoaFiscal)
        {
            _repositorio.Atualizar(pessoaFiscal);
            return pessoaFiscal;
        }
        [HttpGet("{codigo}")]
        public PessoaFiscal Get(int codigo)
        {
            return _repositorio.ObterPorCodigo(codigo);
        }
        [HttpGet]
        public List<PessoaFiscal> Get()
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
