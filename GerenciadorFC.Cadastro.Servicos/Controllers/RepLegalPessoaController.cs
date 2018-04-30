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
    [Route("api/RepLegalPessoa")]
    public class RepLegalPessoaController : Controller
    {
		Repositorio.RepresentanteLegalRepositorio _repositorio = new Repositorio.RepresentanteLegalRepositorio();
		[HttpGet("{codigoPessoa}")]
		public RepresentanteLegal Get(int codigoPessoa)
		{
			return _repositorio.ObterPorCodigoPessoa(codigoPessoa);
		}
	}
}