using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PremierPro.Migrations
{
    /// <inheritdoc />
    public partial class TrecaMigracija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Velicina",
                table: "Proizvod",
                newName: "Velicine");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Velicine",
                table: "Proizvod",
                newName: "Velicina");
        }
    }
}
