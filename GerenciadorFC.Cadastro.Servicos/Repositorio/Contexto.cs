using Microsoft.EntityFrameworkCore;
using GerenciadorFC.Cadastro.Dominio.Implementacao;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace GerenciadorFC.Cadastro.Servicos.Repositorio
{
    public class Contexto : DbContext 
	{
		public DbSet<Pessoa> Pessoas { get; set; }
		public DbSet<RepresentanteLegal> RepresentanteLegals { get; set; }
		public DbSet<Contabilidade> Contabilidades { get; set; }
		public DbSet<Contato> Contatos { get; set; }
		public DbSet<Endereco> Enderecos { get; set; }
		public DbSet<PessoaAgendamento> PessoaAgendamentos { get; set; }
		public DbSet<PessoaFiscal> PessoaFiscals { get; set; }
		public DbSet<PessoaLogin> PessoaLogins { get; set; }
		public DbSet<PessoaContabil> PessoaContabils { get; set; }
		public DbSet<TipoLogin> TipoLogins { get; set; }
		public DbSet<TipoPessoa> TipoPessoas { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=tcp:gerenciadorbilhetagem.database.windows.net,1433;Initial Catalog=dbCadastro; Uid=fabioesimoes; Pwd=q1w2e3r4@;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Pessoa 
			modelBuilder.Entity<Pessoa>().HasKey(p => p.Codigo);
			modelBuilder.Entity<Pessoa>().Property(p => p.Documento).HasMaxLength(15).IsRequired();
		    modelBuilder.Entity<Pessoa>().Property(p => p.DataInclusao).IsRequired();
			modelBuilder.Entity<Pessoa>().Property(p => p.Razao).HasMaxLength(200).IsRequired();
			modelBuilder.Entity<Pessoa>().Property(p => p.Status).IsRequired();
			modelBuilder.Entity<Pessoa>().Property(p => p.TipoPessoa).IsRequired();
			modelBuilder.Entity<Pessoa>().Property(p => p.Excluido).HasDefaultValue(false);

			//RepresentanteLegal

			modelBuilder.Entity<RepresentanteLegal>().HasKey(r => r.Codigo);
			modelBuilder.Entity<RepresentanteLegal>().Property(r => r.CodigoPessoa).IsRequired();
			modelBuilder.Entity<RepresentanteLegal>().Property(r => r.Nome).HasMaxLength(200).IsRequired();
			modelBuilder.Entity<RepresentanteLegal>().Property(r => r.CPF).HasMaxLength(11).IsRequired();
			modelBuilder.Entity<RepresentanteLegal>().Property(r => r.RG).HasMaxLength(10).IsRequired();
			modelBuilder.Entity<RepresentanteLegal>().Property(r => r.DataInclisao).IsRequired();
			modelBuilder.Entity<RepresentanteLegal>().Property(r => r.Status).IsRequired();
			modelBuilder.Entity<RepresentanteLegal>().Property(r => r.Excluido).HasDefaultValue(false);

			//Contabilidade

			modelBuilder.Entity<Contabilidade>().HasKey(c => c.Codigo);
			modelBuilder.Entity<Contabilidade>().Property(c => c.Documento).HasMaxLength(15).IsRequired();
			modelBuilder.Entity<Contabilidade>().Property(c => c.InscricaoMunicipal).HasMaxLength(15);
			modelBuilder.Entity<Contabilidade>().Property(c => c.InscricaoEstadual).HasMaxLength(15);
			modelBuilder.Entity<Contabilidade>().Property(c => c.Nome).HasMaxLength(200);
			modelBuilder.Entity<Contabilidade>().Property(c => c.Razao).HasMaxLength(200).IsRequired();
			modelBuilder.Entity<Contabilidade>().Property(c => c.Registro).HasMaxLength(200).IsRequired();
			modelBuilder.Entity<Contabilidade>().Property(c => c.Status).IsRequired();
			modelBuilder.Entity<Contabilidade>().Property(c => c.DataInclusao).IsRequired();
			modelBuilder.Entity<Contabilidade>().Property(r => r.Excluido).HasDefaultValue(false);

			//Contato
			modelBuilder.Entity<Contato>().HasKey(c => c.Codigo);
			modelBuilder.Entity<Contato>().Property(c => c.CodigoPessoa).IsRequired();
			modelBuilder.Entity<Contato>().Property(c => c.CodigoRepLegal).IsRequired();
			modelBuilder.Entity<Contato>().Property(c => c.DDD).HasMaxLength(4);
			modelBuilder.Entity<Contato>().Property(c => c.Telefone).HasMaxLength(10);
			modelBuilder.Entity<Contato>().Property(c => c.DDDC).HasMaxLength(4);
			modelBuilder.Entity<Contato>().Property(c => c.Celular).HasMaxLength(10);
			modelBuilder.Entity<Contato>().Property(c => c.Excluido).HasDefaultValue(false);

			//Endereco
			modelBuilder.Entity<Endereco>().HasKey(e => e.Codigo);
			modelBuilder.Entity<Endereco>().Property(e => e.CodigoPessoa).IsRequired();
			modelBuilder.Entity<Endereco>().Property(e => e.CodigoRepLegal).IsRequired();
			modelBuilder.Entity<Endereco>().Property(e => e.TipoEnd).HasMaxLength(5);
			modelBuilder.Entity<Endereco>().Property(e => e.Logradouro).HasMaxLength(100);
			modelBuilder.Entity<Endereco>().Property(e => e.Numrero).HasMaxLength(10);
			modelBuilder.Entity<Endereco>().Property(e => e.Complemento).HasMaxLength(40);
			modelBuilder.Entity<Endereco>().Property(e => e.Bairro).HasMaxLength(60);
			modelBuilder.Entity<Endereco>().Property(e => e.Cidade).HasMaxLength(60);
			modelBuilder.Entity<Endereco>().Property(e => e.UF).HasMaxLength(2);
			modelBuilder.Entity<Endereco>().Property(e => e.CEP).HasMaxLength(8);
			modelBuilder.Entity<Endereco>().Property(e => e.Excluido).HasDefaultValue(false);

			//PessoaAgendamento
			modelBuilder.Entity<PessoaAgendamento>().HasKey(e => e.Codigo);
			modelBuilder.Entity<PessoaAgendamento>().Property(e => e.CodigoFiscal).HasMaxLength(20);
			modelBuilder.Entity<PessoaAgendamento>().Property(e => e.CodigoPessoa).IsRequired();
			modelBuilder.Entity<PessoaAgendamento>().Property(e => e.Excluido).HasDefaultValue(false);

			//PessoaContabil
			modelBuilder.Entity<PessoaContabil>().HasKey(p => p.Codigo);
			modelBuilder.Entity<PessoaContabil>().Property(p => p.CodigoContabil).IsRequired();
			modelBuilder.Entity<PessoaContabil>().Property(p => p.CodigoPessoa).IsRequired();
			modelBuilder.Entity<PessoaContabil>().Property(p => p.Excluido).HasDefaultValue(false);

			//PessoaFiscal
			modelBuilder.Entity<PessoaFiscal>().HasKey(p => p.Codigo);
			modelBuilder.Entity<PessoaFiscal>().Property(p => p.CodigoFiscal).HasMaxLength(50);
			modelBuilder.Entity<PessoaFiscal>().Property(p => p.CodigoPessoa).IsRequired();
			modelBuilder.Entity<PessoaFiscal>().Property(p => p.TipoEmpresa).HasMaxLength(50);
			modelBuilder.Entity<PessoaFiscal>().Property(p => p.AnexoFiscal).HasMaxLength(200);
			modelBuilder.Entity<PessoaFiscal>().Property(p => p.Excluido).HasDefaultValue(false);

			//PessoaLogin
			modelBuilder.Entity<PessoaLogin>().HasKey(p => p.Codigo);
			modelBuilder.Entity<PessoaLogin>().Property(p => p.CodigoPessoa).IsRequired();
			modelBuilder.Entity<PessoaLogin>().Property(p => p.DataInclusao).IsRequired();
			modelBuilder.Entity<PessoaLogin>().Property(p => p.TipoLogin).IsRequired();
			modelBuilder.Entity<PessoaLogin>().Property(p => p.Excluido).HasDefaultValue(false);

			//TipoLogin
			modelBuilder.Entity<TipoLogin>().HasKey(t => t.Codigo);
			modelBuilder.Entity<TipoLogin>().Property(t => t.Tipo).HasMaxLength(10);

			//TipoPessoa
			modelBuilder.Entity<TipoPessoa>().HasKey(t => t.Codigo);
			modelBuilder.Entity<TipoPessoa>().Property(t => t.Tipo).HasMaxLength(10);
		}

		
	}
}
