using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace GerenciadorFC.Cadastro.Servicos.Controllers
{

    [Route("api/RepresentanteLegal")]
    public class RepresentanteLegalController : Controller
    {
        Repositorio.RepresentanteLegalRepositorio _repositorio = new Repositorio.RepresentanteLegalRepositorio();
        [HttpPost]
        public RepresentanteLegal Post([FromBody]RepresentanteLegal representanteLegal)
        {
            _repositorio.Adicionar(representanteLegal);
            return representanteLegal;
        }
        [HttpPut]
        public RepresentanteLegal Put([FromBody]RepresentanteLegal representanteLegal)
        {
            _repositorio.Atualizar(representanteLegal);
            return representanteLegal;
        }
        [HttpGet("{codigo}")]
        public RepresentanteLegal Get(int codigo)
        {
            return _repositorio.ObterPorCodigo(codigo);
        }	
		[HttpGet]
        public List<RepresentanteLegal> Get()
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
