using Microsoft.EntityFrameworkCore.Migrations;

namespace mrsProject.Migrations
{
    public partial class AddBookUniqueID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeedPassword",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TempRole",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookUniqueID",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeedPassword",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TempRole",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BookUniqueID",
                table: "Books");
        }
    }
}
