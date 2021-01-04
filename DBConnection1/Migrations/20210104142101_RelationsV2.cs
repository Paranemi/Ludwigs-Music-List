using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBConnection1.Migrations
{
    public partial class RelationsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SongId",
                table: "LikedSong",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_LikedSong_SongId",
                table: "LikedSong",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedSong_Songs_SongId",
                table: "LikedSong",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikedSong_Songs_SongId",
                table: "LikedSong");

            migrationBuilder.DropIndex(
                name: "IX_LikedSong_SongId",
                table: "LikedSong");

            migrationBuilder.DropColumn(
                name: "SongId",
                table: "LikedSong");
        }
    }
}
