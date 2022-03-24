using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderIn.Storage.Migrations
{
    public partial class WorkingOutDrinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Drinks",
                table: "Drinks");

            migrationBuilder.RenameTable(
                name: "Drinks",
                newName: "ADrink");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ADrink",
                table: "ADrink",
                column: "EntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ADrink",
                table: "ADrink");

            migrationBuilder.RenameTable(
                name: "ADrink",
                newName: "Drinks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drinks",
                table: "Drinks",
                column: "EntityId");
        }
    }
}
