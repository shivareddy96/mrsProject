using Microsoft.EntityFrameworkCore.Migrations;

namespace mrsProject.Migrations
{
    public partial class SubtotalSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OrderSubtotal",
                table: "Orders",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderSubtotal",
                table: "Orders");
        }
    }
}
