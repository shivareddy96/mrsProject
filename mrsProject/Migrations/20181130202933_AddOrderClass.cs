using Microsoft.EntityFrameworkCore.Migrations;

namespace mrsProject.Migrations
{
    public partial class AddOrderClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderNotes",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderDetailPrice",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<decimal>(
                name: "OrderExtendedPrice",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNotes",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderExtendedPrice",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "OrderDetailPrice",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
