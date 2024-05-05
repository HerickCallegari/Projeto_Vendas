using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicativoVendas.Migrations
{
    /// <inheritdoc />
    public partial class repairItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ItemId",
                table: "Pedidos",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Items_ItemId",
                table: "Pedidos",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Items_ItemId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ItemId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Pedidos");
        }
    }
}
