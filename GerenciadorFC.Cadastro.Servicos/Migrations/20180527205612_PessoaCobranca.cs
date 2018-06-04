using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class PessoaCobranca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodePrepoval",
                table: "PessoaCobranca",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "PessoaCobranca",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodePrepoval",
                table: "PessoaCobranca");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "PessoaCobranca");
        }
    }
}
