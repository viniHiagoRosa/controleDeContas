using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace financeiro.Migrations
{
    /// <inheritdoc />
    public partial class adicionadogetLista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ValorDaConta",
                table: "ControleDeContas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDaConta",
                table: "ControleDeContas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
