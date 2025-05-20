using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class prestito : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LibroId",
                table: "Prestiti");

            migrationBuilder.DropColumn(
                name: "UtenteId",
                table: "Prestiti");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Prestiti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Isbn",
                table: "Prestiti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Prestiti");

            migrationBuilder.DropColumn(
                name: "Isbn",
                table: "Prestiti");

            migrationBuilder.AddColumn<Guid>(
                name: "LibroId",
                table: "Prestiti",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UtenteId",
                table: "Prestiti",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
