using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MvcMovie.Migrations
{
    public partial class NewReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Review",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "movieID",
                table: "Review",
                newName: "MovieID");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Review",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "review",
                table: "Review",
                newName: "Comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Review",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Review",
                newName: "movieID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Review",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Review",
                newName: "review");
        }
    }
}
