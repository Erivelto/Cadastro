using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataExpedicaoPassaporte",
                table: "RepresentanteLegals",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExpedicaoRG",
                table: "RepresentanteLegals",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CNAE",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAbertura",
                table: "Pessoas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DescricaoAtividade",
                table: "Pessoas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataExpedicaoPassaporte",
                table: "RepresentanteLegals");

            migrationBuilder.DropColumn(
                name: "DataExpedicaoRG",
                table: "RepresentanteLegals");

            migrationBuilder.DropColumn(
                name: "CNAE",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DataAbertura",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "DescricaoAtividade",
                table: "Pessoas");
        }
    }
}
