using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MvcMovie.Migrations
{
    public partial class MovieForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Review_MovieID",
                table: "Review",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Movie_MovieID",
                table: "Review",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movie_MovieID",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_MovieID",
                table: "Review");
        }
    }
}
