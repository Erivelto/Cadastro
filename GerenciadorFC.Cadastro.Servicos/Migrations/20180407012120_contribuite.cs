using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class contribuite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnexoFiscal",
                table: "PessoaFiscals");

            migrationBuilder.AddColumn<string>(
                name: "CodigoContribuite",
                table: "PessoaFiscals",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Excluido",
                table: "PessoaEmissaoNFe",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Excluido",
                table: "ItensNotas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoVerificacao",
                table: "DadosNota",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Excluido",
                table: "DadosNota",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "AnexoFiscal",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Anexo = table.Column<string>(nullable: true),
                    Excluido = table.Column<bool>(nullable: false),
                    PessoaFiscalCodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnexoFiscal", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_AnexoFiscal_PessoaFiscals_PessoaFiscalCodigo",
                        column: x => x.PessoaFiscalCodigo,
                        principalTable: "PessoaFiscals",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFiscalHistorico",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataGeracaoDAS = table.Column<DateTime>(nullable: false),
                    EnviadoCliente = table.Column<bool>(nullable: false),
                    MesReferencia = table.Column<int>(nullable: false),
                    PessoaFiscalCodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFiscalHistorico", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_PessoaFiscalHistorico_PessoaFiscals_PessoaFiscalCodigo",
                        column: x => x.PessoaFiscalCodigo,
                        principalTable: "PessoaFiscals",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnexoFiscal_PessoaFiscalCodigo",
                table: "AnexoFiscal",
                column: "PessoaFiscalCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFiscalHistorico_PessoaFiscalCodigo",
                table: "PessoaFiscalHistorico",
                column: "PessoaFiscalCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnexoFiscal");

            migrationBuilder.DropTable(
                name: "PessoaFiscalHistorico");

            migrationBuilder.DropColumn(
                name: "CodigoContribuite",
                table: "PessoaFiscals");

            migrationBuilder.DropColumn(
                name: "Excluido",
                table: "PessoaEmissaoNFe");

            migrationBuilder.DropColumn(
                name: "Excluido",
                table: "ItensNotas");

            migrationBuilder.DropColumn(
                name: "Excluido",
                table: "DadosNota");

            migrationBuilder.AddColumn<string>(
                name: "AnexoFiscal",
                table: "PessoaFiscals",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoVerificacao",
                table: "DadosNota",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
