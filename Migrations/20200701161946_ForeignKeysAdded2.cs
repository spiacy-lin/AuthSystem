using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthSystem.Migrations
{
    public partial class ForeignKeysAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Guest",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guest_ApplicationUserId",
                table: "Guest",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_AspNetUsers_ApplicationUserId",
                table: "Guest",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.DropForeignKey(
                name: "FK_Guest_AspNetUsers_UserId",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_UserId",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Guest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_AspNetUsers_ApplicationUserId",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_ApplicationUserId",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Guest");
        }
    }
}
