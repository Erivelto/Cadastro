using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace GerenciadorFC.Cadastro.Servicos.Migrations
{
    public partial class postCobranca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotificacaoPagamento",
                columns: table => new
                {
                    codigo = table.Column<Guid>(nullable: false),
                    codigoPessoa = table.Column<int>(nullable: false),
                    notificationCode = table.Column<string>(nullable: true),
                    notificationType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificacaoPagamento", x => x.codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificacaoPagamento");
        }
    }
}
