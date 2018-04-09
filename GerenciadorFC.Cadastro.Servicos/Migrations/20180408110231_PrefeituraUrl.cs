using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class PrefeituraUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "prefeitura",
                table: "PessoaEmissaoNFe",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "urlPrefeitura",
                table: "PessoaEmissaoNFe",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "urlPrefeitura",
                table: "PessoaEmissaoNFe");

            migrationBuilder.AlterColumn<string>(
                name: "prefeitura",
                table: "PessoaEmissaoNFe",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
