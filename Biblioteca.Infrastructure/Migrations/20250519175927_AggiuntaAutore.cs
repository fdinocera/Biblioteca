using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntaAutore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autore",
                table: "Libri",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autore",
                table: "Libri");
        }
    }
}
