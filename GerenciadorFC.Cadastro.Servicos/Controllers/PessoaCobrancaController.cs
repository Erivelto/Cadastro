using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Route("api/PessoaCobranca")]
    public class PessoaCobrancaController : Controller
    {
		Repositorio.PessoaCobrancaRepositorio _repositorio = new Repositorio.PessoaCobrancaRepositorio();
		// GET: api/PessoaCobranca
		[HttpGet]
        public List<PessoaCobranca> Get()
        {
            return _repositorio.ObterLista();
        }
        // GET: api/PessoaCobranca/5
        [HttpGet("{transacao}")]
        public PessoaCobranca Get(string transacao)
        {
            return _repositorio.ObterPorCodigo(transacao);
        }        
        // POST: api/PessoaCobranca
        [HttpPost]
        public PessoaCobranca Post([FromBody]PessoaCobranca pessoaCobranca)
        {
			return _repositorio.Adicionar(pessoaCobranca);
        }
		[HttpPost("{transacao_id}")]
		public void Post(string transacao_id)
		{
			PessoaCobranca pessoaCobranca = new PessoaCobranca();
			pessoaCobranca.Transacao = transacao_id;
			_repositorio.Adicionar(pessoaCobranca);			
		}
		// PUT: api/PessoaCobranca/5
		[HttpPut]
        public PessoaCobranca Put([FromBody]PessoaCobranca pessoaCobranca)
        {
			return _repositorio.Atualizar(pessoaCobranca);
        }
    }
}
