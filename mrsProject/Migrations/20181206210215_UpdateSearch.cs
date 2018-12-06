using Microsoft.EntityFrameworkCore.Migrations;

namespace mrsProject.Migrations
{
    public partial class UpdateSearch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DiscountNum",
                table: "Discounts",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "NumPurchased",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountNum",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "NumPurchased",
                table: "Books");
        }
    }
}
