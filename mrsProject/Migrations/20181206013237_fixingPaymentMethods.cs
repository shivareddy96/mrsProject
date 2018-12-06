using Microsoft.EntityFrameworkCore.Migrations;

namespace mrsProject.Migrations
{
    public partial class fixingPaymentMethods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditCard1Type",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreditCard2Type",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreditCard3Type",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreditCard1Type",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreditCard2Type",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreditCard3Type",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
