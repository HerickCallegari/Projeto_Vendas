using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicativoVendas.Migrations
{
    /// <inheritdoc />
    public partial class modificandobanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Pedidos",
                newName: "Data");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Pedidos",
                newName: "DateTime");
        }
    }
}
