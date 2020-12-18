using Microsoft.EntityFrameworkCore.Migrations;

namespace DBConnection1.Migrations
{
    public partial class AddImageUrlToArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistImageUrl",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistImageUrl",
                table: "Artists");
        }
    }
}
