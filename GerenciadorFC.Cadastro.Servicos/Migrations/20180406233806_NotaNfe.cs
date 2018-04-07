using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class NotaNfe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PessoaEmissaoNFe_DadosNota_dadosNotaCodigo",
                table: "PessoaEmissaoNFe");

            migrationBuilder.DropIndex(
                name: "IX_PessoaEmissaoNFe_dadosNotaCodigo",
                table: "PessoaEmissaoNFe");

            migrationBuilder.DropColumn(
                name: "dadosNotaCodigo",
                table: "PessoaEmissaoNFe");

            migrationBuilder.DropColumn(
                name: "CodigoDadosNota",
                table: "ItensNotas");

            migrationBuilder.DropColumn(
                name: "CodigoPessoaEmissaoNFe",
                table: "DadosNota");

            migrationBuilder.AddColumn<int>(
                name: "PessoaEmissaoNFeCodigo",
                table: "DadosNota",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DadosNota_PessoaEmissaoNFeCodigo",
                table: "DadosNota",
                column: "PessoaEmissaoNFeCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_DadosNota_PessoaEmissaoNFe_PessoaEmissaoNFeCodigo",
                table: "DadosNota",
                column: "PessoaEmissaoNFeCodigo",
                principalTable: "PessoaEmissaoNFe",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DadosNota_PessoaEmissaoNFe_PessoaEmissaoNFeCodigo",
                table: "DadosNota");

            migrationBuilder.DropIndex(
                name: "IX_DadosNota_PessoaEmissaoNFeCodigo",
                table: "DadosNota");

            migrationBuilder.DropColumn(
                name: "PessoaEmissaoNFeCodigo",
                table: "DadosNota");

            migrationBuilder.AddColumn<int>(
                name: "dadosNotaCodigo",
                table: "PessoaEmissaoNFe",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodigoDadosNota",
                table: "ItensNotas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodigoPessoaEmissaoNFe",
                table: "DadosNota",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PessoaEmissaoNFe_dadosNotaCodigo",
                table: "PessoaEmissaoNFe",
                column: "dadosNotaCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaEmissaoNFe_DadosNota_dadosNotaCodigo",
                table: "PessoaEmissaoNFe",
                column: "dadosNotaCodigo",
                principalTable: "DadosNota",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
