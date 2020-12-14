using Microsoft.EntityFrameworkCore.Migrations;

namespace DBConnection1.Migrations
{
    public partial class RemovedImageUrlFromSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Songs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
