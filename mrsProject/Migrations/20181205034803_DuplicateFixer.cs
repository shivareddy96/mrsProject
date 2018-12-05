using Microsoft.EntityFrameworkCore.Migrations;

namespace mrsProject.Migrations
{
    public partial class DuplicateFixer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalesTax",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Orders",
                newName: "ShippingCostNextBook");

            migrationBuilder.RenameColumn(
                name: "Subtotal",
                table: "Orders",
                newName: "ShippingCostFirstBook");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShippingCostNextBook",
                table: "Orders",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "ShippingCostFirstBook",
                table: "Orders",
                newName: "Subtotal");

            migrationBuilder.AddColumn<decimal>(
                name: "SalesTax",
                table: "Orders",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
