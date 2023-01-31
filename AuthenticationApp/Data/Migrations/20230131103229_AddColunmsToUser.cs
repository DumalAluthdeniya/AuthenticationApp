using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthenticationApp.Data.Migrations
{
    public partial class AddColunmsToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nric",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResumePath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhoAmI",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nric",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ResumePath",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WhoAmI",
                table: "AspNetUsers");
        }
    }
}
