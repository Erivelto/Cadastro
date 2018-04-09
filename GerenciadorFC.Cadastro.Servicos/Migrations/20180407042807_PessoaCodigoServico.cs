using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class PessoaCodigoServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoServico",
                table: "DadosNota");

            migrationBuilder.CreateTable(
                name: "PessoaCodigoServico",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoServico = table.Column<string>(nullable: true),
                    Excluido = table.Column<bool>(nullable: false),
                    PessoaEmissaoNFeCodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaCodigoServico", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_PessoaCodigoServico_PessoaEmissaoNFe_PessoaEmissaoNFeCodigo",
                        column: x => x.PessoaEmissaoNFeCodigo,
                        principalTable: "PessoaEmissaoNFe",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCodigoServico_PessoaEmissaoNFeCodigo",
                table: "PessoaCodigoServico",
                column: "PessoaEmissaoNFeCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaCodigoServico");

            migrationBuilder.AddColumn<int>(
                name: "CodigoServico",
                table: "DadosNota",
                nullable: false,
                defaultValue: 0);
        }
    }
}
