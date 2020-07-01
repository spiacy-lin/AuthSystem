using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthSystem.Migrations
{
    public partial class Updateguests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Guest");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Guest",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guest_UserId",
                table: "Guest",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_AspNetUsers_UserId",
                table: "Guest",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_AspNetUsers_UserId",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_UserId",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Guest");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Guest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Guest",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
