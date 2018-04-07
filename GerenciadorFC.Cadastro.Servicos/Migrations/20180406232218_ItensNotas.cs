using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class ItensNotas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DadosNota",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoPessoaEmissaoNFe = table.Column<int>(nullable: false),
                    CodigoServico = table.Column<int>(nullable: false),
                    CodigoVerificacao = table.Column<string>(nullable: true),
                    DataEmissao = table.Column<DateTime>(nullable: false),
                    DataEnvio = table.Column<DateTime>(nullable: false),
                    NumeroNFE = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosNota", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "ItensNotas",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoDadosNota = table.Column<int>(nullable: false),
                    DadosNotaCodigo = table.Column<int>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    ValorUni = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensNotas", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_ItensNotas_DadosNota_DadosNotaCodigo",
                        column: x => x.DadosNotaCodigo,
                        principalTable: "DadosNota",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaEmissaoNFe",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoPessoa = table.Column<int>(nullable: false),
                    dadosNotaCodigo = table.Column<int>(nullable: true),
                    senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaEmissaoNFe", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_PessoaEmissaoNFe_DadosNota_dadosNotaCodigo",
                        column: x => x.dadosNotaCodigo,
                        principalTable: "DadosNota",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensNotas_DadosNotaCodigo",
                table: "ItensNotas",
                column: "DadosNotaCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaEmissaoNFe_dadosNotaCodigo",
                table: "PessoaEmissaoNFe",
                column: "dadosNotaCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensNotas");

            migrationBuilder.DropTable(
                name: "PessoaEmissaoNFe");

            migrationBuilder.DropTable(
                name: "DadosNota");
        }
    }
}
