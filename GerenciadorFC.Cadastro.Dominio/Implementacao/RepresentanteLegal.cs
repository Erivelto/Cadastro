﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorFC.Cadastro.Dominio.Implementacao
{
    public class RepresentanteLegal
    {
		public int Codigo { get; set; }
		public int CodigoPessoa { get; set; }
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string RG { get; set; }
		public string Passaporte { get; set; }
		public DateTime DataExpedicaoRG { get; set; }
		public DateTime DataExpedicaoPassaporte { get; set; }
		public DateTime DataInclisao { get; set; }
		public DateTime DataAlteracao { get; set; }
		public int Status { get; set; }
		public bool Excluido { get; set; }		
	}
}
