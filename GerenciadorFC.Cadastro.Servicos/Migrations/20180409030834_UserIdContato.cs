using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class UserIdContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RepresentanteLegals");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Contatos",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Contatos");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "RepresentanteLegals",
                maxLength: 100,
                nullable: true);
        }
    }
}
