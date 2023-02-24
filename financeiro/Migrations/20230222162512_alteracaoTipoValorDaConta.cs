﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace financeiro.Migrations
{
    /// <inheritdoc />
    public partial class alteracaoTipoValorDaConta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDaConta",
                table: "ControleDeContas",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ValorDaConta",
                table: "ControleDeContas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");
        }
    }
}
