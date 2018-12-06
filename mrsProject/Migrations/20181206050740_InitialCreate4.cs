using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mrsProject.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DiscountDescription",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "CreditCard1Type",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreditCard2Type",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreditCard3Type",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "DiscountActive",
                table: "Discounts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountActive",
                table: "Discounts");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiscountDescription",
                table: "Discounts",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Discounts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Discounts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
