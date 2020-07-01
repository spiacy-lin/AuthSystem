using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthSystem.Migrations
{
    public partial class Cleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_AspNetUsers_ApplicationUserId",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_ApplicationUserId",
                table: "Guest");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Guest",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Guest",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
        }
    }
}
