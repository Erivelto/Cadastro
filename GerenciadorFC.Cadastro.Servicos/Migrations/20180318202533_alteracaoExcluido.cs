using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class alteracaoExcluido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PessoaLogin",
                table: "PessoaLogin");

            migrationBuilder.DropColumn(
                name: "Exluido",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "PessoaLogin",
                newName: "PessoaLogins");

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "RepresentanteLegals",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Excluido",
                table: "Pessoas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Excluido",
                table: "PessoaLogins",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "PessoaFiscals",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "PessoaContabils",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "PessoaAgendamentos",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "Enderecos",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "Contatos",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "Contabilidades",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PessoaLogins",
                table: "PessoaLogins",
                column: "Codigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PessoaLogins",
                table: "PessoaLogins");

            migrationBuilder.DropColumn(
                name: "Excluido",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Excluido",
                table: "PessoaLogins");

            migrationBuilder.RenameTable(
                name: "PessoaLogins",
                newName: "PessoaLogin");

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "RepresentanteLegals",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Exluido",
                table: "Pessoas",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "PessoaFiscals",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "PessoaContabils",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "PessoaAgendamentos",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "Enderecos",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "Contatos",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Excluido",
                table: "Contabilidades",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PessoaLogin",
                table: "PessoaLogin",
                column: "Codigo");
        }
    }
}
