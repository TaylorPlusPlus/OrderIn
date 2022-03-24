using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderIn.Storage.Migrations
{
    public partial class FixDrinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderEntityId",
                table: "ADrink",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ADrink_OrderEntityId",
                table: "ADrink",
                column: "OrderEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ADrink_Orders_OrderEntityId",
                table: "ADrink",
                column: "OrderEntityId",
                principalTable: "Orders",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ADrink_Orders_OrderEntityId",
                table: "ADrink");

            migrationBuilder.DropIndex(
                name: "IX_ADrink_OrderEntityId",
                table: "ADrink");

            migrationBuilder.DropColumn(
                name: "OrderEntityId",
                table: "ADrink");
        }
    }
}
