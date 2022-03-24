using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderIn.Storage.Migrations
{
    public partial class AddingDrinkProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Cost",
                table: "ADrink",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ADrink",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "ADrink");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ADrink");
        }
    }
}
