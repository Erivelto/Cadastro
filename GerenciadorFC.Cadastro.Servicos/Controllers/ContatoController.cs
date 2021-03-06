﻿using GerenciadorFC.Cadastro.Dominio.Implementacao;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Controllers
{
    [Produces("application/json")]
    [Route("api/Contato")]
    public class ContatoController : Controller
    {
		// GET: api/Contabilidade
		Repositorio.ContatoRepositorio _repositorio = new Repositorio.ContatoRepositorio();
		[HttpPost]
		public Contato Post([FromBody]Contato contato)
		{
			_repositorio.Adicionar(contato);
			return contato;
		}
		[HttpPut]
		public Contato Put([FromBody]Contato contato)
		{
			_repositorio.Atualizar(contato);
			return contato;
		}
		[HttpGet("{codigo}")]
		public Contato Get(int codigo)
		{
			return _repositorio.ObterPorCodigo(codigo);
		}
		[HttpGet("UserId/{userId}")]
		public Contato Get(string userId)
		{
			return _repositorio.ObterPorUserId(userId);
		}
		[HttpGet]		
		public List<Contato> Get(int codigoRep,int val = 0)
		{
			return _repositorio.ObterLista(codigoRep);
		}
		[HttpGet("Status/{codigoStatus}")]
		public bool GetStatus(int codigoStatus)
		{
			return _repositorio.AtualizaStatus(codigoStatus);
		}
		[HttpDelete]
		public bool Delete(int codigo)
		{
			return _repositorio.Excluir(codigo);
		}
	}
}
