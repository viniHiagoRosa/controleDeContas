using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace financeiro.Migrations
{
    /// <inheritdoc />
    public partial class adicionado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Parcelar",
                table: "ControleDeContas",
                newName: "Parcelas");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDaConta",
                table: "ControleDeContas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Parcelas",
                table: "ControleDeContas",
                newName: "Parcelar");

            migrationBuilder.AlterColumn<int>(
                name: "ValorDaConta",
                table: "ControleDeContas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
