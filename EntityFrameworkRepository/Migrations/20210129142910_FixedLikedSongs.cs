using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRepository.Migrations
{
    public partial class FixedLikedSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LikedSong_Songs_SongsSongId",
                table: "LikedSong");

            migrationBuilder.DropIndex(
                name: "IX_LikedSong_SongsSongId",
                table: "LikedSong");

            migrationBuilder.DropColumn(
                name: "SongsSongId",
                table: "LikedSong");

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

            migrationBuilder.AddColumn<Guid>(
                name: "SongsSongId",
                table: "LikedSong",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LikedSong_SongsSongId",
                table: "LikedSong",
                column: "SongsSongId");

            migrationBuilder.AddForeignKey(
                name: "FK_LikedSong_Songs_SongsSongId",
                table: "LikedSong",
                column: "SongsSongId",
                principalTable: "Songs",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
