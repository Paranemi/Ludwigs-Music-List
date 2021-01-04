using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBConnection1.Migrations
{
    public partial class RelationsV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AlbumId",
                table: "LikedAlbum",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_LikedAlbum_AlbumId",
                table: "LikedAlbum",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedAlbum_Albums_AlbumId",
                table: "LikedAlbum",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikedAlbum_Albums_AlbumId",
                table: "LikedAlbum");

            migrationBuilder.DropIndex(
                name: "IX_LikedAlbum_AlbumId",
                table: "LikedAlbum");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "LikedAlbum");
        }
    }
}
