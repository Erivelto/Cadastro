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
        public PessoaCobranca Get(string transacao = null, string referencia = null, string code = null)
        {
			var pessoacobranca = new PessoaCobranca();
			if (transacao != null)
				pessoacobranca = _repositorio.ObterPorCodigo(transacao);
			if (referencia != null)
				pessoacobranca = _repositorio.ObterPorReferencia(referencia);
			if (code != null)
				pessoacobranca = _repositorio.ObterPorCodePrepoval(code);

			return pessoacobranca;

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
