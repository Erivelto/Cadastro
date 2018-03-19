﻿// <auto-generated />
using GerenciadorFC.Cadastro.Servicos.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20180306030323_setupinitial")]
    partial class setupinitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.Contabilidade", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtulizacao");

                    b.Property<DateTime>("DataInclusao");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(15);

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(15);

                    b.Property<string>("Nome")
                        .HasMaxLength(200);

                    b.Property<string>("Razao")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Status");

                    b.HasKey("Codigo");

                    b.ToTable("Contabilidades");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.Contato", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular")
                        .HasMaxLength(10);

                    b.Property<int>("CodigoPessoa");

                    b.Property<int>("CodigoRepLegal");

                    b.Property<string>("DDD")
                        .HasMaxLength(4);

                    b.Property<string>("DDDC")
                        .HasMaxLength(4);

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Site");

                    b.Property<string>("Telefone")
                        .HasMaxLength(10);

                    b.Property<string>("email");

                    b.HasKey("Codigo");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.Endereco", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .HasMaxLength(60);

                    b.Property<string>("CEP")
                        .HasMaxLength(8);

                    b.Property<string>("Cidade")
                        .HasMaxLength(60);

                    b.Property<int>("CodigoPessoa");

                    b.Property<int>("CodigoRepLegal");

                    b.Property<string>("Complemento")
                        .HasMaxLength(40);

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Logradouro")
                        .HasMaxLength(100);

                    b.Property<string>("Numrero")
                        .HasMaxLength(10);

                    b.Property<string>("TipoEnd")
                        .HasMaxLength(5);

                    b.Property<string>("UF")
                        .HasMaxLength(2);

                    b.HasKey("Codigo");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.Pessoa", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataAtulizacao");

                    b.Property<DateTime>("DataInclusao");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<bool>("Exluido")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("IncricaoMunicipal");

                    b.Property<string>("Nome");

                    b.Property<string>("Razao")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Status");

                    b.Property<int>("TipoPessoa");

                    b.HasKey("Codigo");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.PessoaAgendamento", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoFiscal")
                        .HasMaxLength(20);

                    b.Property<int>("CodigoPessoa");

                    b.Property<int>("DiaFaturamento");

                    b.Property<int>("DiaImposto");

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.HasKey("Codigo");

                    b.ToTable("PessoaAgendamentos");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.PessoaContabil", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodigoContabil");

                    b.Property<int>("CodigoPessoa");

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.HasKey("Codigo");

                    b.ToTable("PessoaContabils");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.PessoaFiscal", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnexoFiscal")
                        .HasMaxLength(200);

                    b.Property<string>("CodigoFiscal")
                        .HasMaxLength(50);

                    b.Property<int>("CodigoPessoa");

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("TipoEmpresa")
                        .HasMaxLength(50);

                    b.HasKey("Codigo");

                    b.ToTable("PessoaFiscals");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.PessoaLogin", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodigoPessoa");

                    b.Property<DateTime>("DataInclusao");

                    b.Property<DateTime>("DataUltimoAcesso");

                    b.Property<int>("TipoLogin");

                    b.HasKey("Codigo");

                    b.ToTable("PessoaLogin");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.RepresentanteLegal", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<int>("CodigoPessoa");

                    b.Property<DateTime>("DataAlteracao");

                    b.Property<DateTime>("DataInclisao");

                    b.Property<bool>("Excluido")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Passaporte");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("Status");

                    b.HasKey("Codigo");

                    b.ToTable("RepresentanteLegals");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.TipoLogin", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tipo")
                        .HasMaxLength(10);

                    b.HasKey("Codigo");

                    b.ToTable("TipoLogins");
                });

            modelBuilder.Entity("GerenciadorFC.Cadastro.Dominio.Implementacao.TipoPessoa", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tipo")
                        .HasMaxLength(10);

                    b.HasKey("Codigo");

                    b.ToTable("TipoPessoas");
                });
#pragma warning restore 612, 618
        }
    }
}
