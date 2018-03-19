using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class setupinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contabilidades",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAtulizacao = table.Column<DateTime>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    Documento = table.Column<string>(maxLength: 15, nullable: false),
                    Excluido = table.Column<bool>(nullable: false, defaultValue: true),
                    InscricaoEstadual = table.Column<string>(maxLength: 15, nullable: true),
                    InscricaoMunicipal = table.Column<string>(maxLength: 15, nullable: true),
                    Nome = table.Column<string>(maxLength: 200, nullable: true),
                    Razao = table.Column<string>(maxLength: 200, nullable: false),
                    Registro = table.Column<string>(maxLength: 200, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contabilidades", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Celular = table.Column<string>(maxLength: 10, nullable: true),
                    CodigoPessoa = table.Column<int>(nullable: false),
                    CodigoRepLegal = table.Column<int>(nullable: false),
                    DDD = table.Column<string>(maxLength: 4, nullable: true),
                    DDDC = table.Column<string>(maxLength: 4, nullable: true),
                    Excluido = table.Column<bool>(nullable: false, defaultValue: true),
                    Site = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(maxLength: 10, nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(maxLength: 60, nullable: true),
                    CEP = table.Column<string>(maxLength: 8, nullable: true),
                    Cidade = table.Column<string>(maxLength: 60, nullable: true),
                    CodigoPessoa = table.Column<int>(nullable: false),
                    CodigoRepLegal = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(maxLength: 40, nullable: true),
                    Excluido = table.Column<bool>(nullable: false, defaultValue: true),
                    Logradouro = table.Column<string>(maxLength: 100, nullable: true),
                    Numrero = table.Column<string>(maxLength: 10, nullable: true),
                    TipoEnd = table.Column<string>(maxLength: 5, nullable: true),
                    UF = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "PessoaAgendamentos",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoFiscal = table.Column<string>(maxLength: 20, nullable: true),
                    CodigoPessoa = table.Column<int>(nullable: false),
                    DiaFaturamento = table.Column<int>(nullable: false),
                    DiaImposto = table.Column<int>(nullable: false),
                    Excluido = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaAgendamentos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "PessoaContabils",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoContabil = table.Column<int>(nullable: false),
                    CodigoPessoa = table.Column<int>(nullable: false),
                    Excluido = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaContabils", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFiscals",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnexoFiscal = table.Column<string>(maxLength: 200, nullable: true),
                    CodigoFiscal = table.Column<string>(maxLength: 50, nullable: true),
                    CodigoPessoa = table.Column<int>(nullable: false),
                    Excluido = table.Column<bool>(nullable: false, defaultValue: true),
                    TipoEmpresa = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFiscals", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "PessoaLogin",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoPessoa = table.Column<int>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataUltimoAcesso = table.Column<DateTime>(nullable: false),
                    TipoLogin = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaLogin", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAtulizacao = table.Column<DateTime>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    Documento = table.Column<string>(maxLength: 15, nullable: false),
                    Exluido = table.Column<bool>(nullable: false, defaultValue: true),
                    IncricaoMunicipal = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Razao = table.Column<string>(maxLength: 200, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TipoPessoa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "RepresentanteLegals",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<string>(maxLength: 11, nullable: false),
                    CodigoPessoa = table.Column<int>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    DataInclisao = table.Column<DateTime>(nullable: false),
                    Excluido = table.Column<bool>(nullable: false, defaultValue: true),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    Passaporte = table.Column<string>(nullable: true),
                    RG = table.Column<string>(maxLength: 10, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentanteLegals", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "TipoLogins",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoLogins", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "TipoPessoas",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPessoas", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contabilidades");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "PessoaAgendamentos");

            migrationBuilder.DropTable(
                name: "PessoaContabils");

            migrationBuilder.DropTable(
                name: "PessoaFiscals");

            migrationBuilder.DropTable(
                name: "PessoaLogin");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "RepresentanteLegals");

            migrationBuilder.DropTable(
                name: "TipoLogins");

            migrationBuilder.DropTable(
                name: "TipoPessoas");
        }
    }
}
