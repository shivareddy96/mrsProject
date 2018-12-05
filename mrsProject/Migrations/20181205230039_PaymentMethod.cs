using Microsoft.EntityFrameworkCore.Migrations;

namespace mrsProject.Migrations
{
    public partial class PaymentMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShippingCostFirstBook",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShippingCostNextBook",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Orders");

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingCostFirstBook",
                table: "Orders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingCostNextBook",
                table: "Orders",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
