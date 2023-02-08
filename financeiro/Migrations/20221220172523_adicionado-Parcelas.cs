using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace financeiro.Migrations
{
    /// <inheritdoc />
    public partial class adicionadoParcelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Parcelar",
                table: "ControleDeContas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parcelar",
                table: "ControleDeContas");
        }
    }
}
