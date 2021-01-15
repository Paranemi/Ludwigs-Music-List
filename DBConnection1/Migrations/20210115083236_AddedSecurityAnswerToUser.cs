using Microsoft.EntityFrameworkCore.Migrations;

namespace DBConnection1.Migrations
{
    public partial class AddedSecurityAnswerToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecurityAnswer",
                table: "Users",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecurityAnswer",
                table: "Users");
        }
    }
}
