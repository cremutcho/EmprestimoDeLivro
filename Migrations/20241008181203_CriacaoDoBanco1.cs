using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimoLivro.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoDoBanco1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LivroEmprestado",
                table: "Emprestimos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LivroEmprestado",
                table: "Emprestimos");
        }
    }
}
