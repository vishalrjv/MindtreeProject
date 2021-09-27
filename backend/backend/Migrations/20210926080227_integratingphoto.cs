using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class integratingphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookName",
                table: "books",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Uploadedon",
                table: "books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "photoId",
                table: "books",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_userloginnews_UserId",
                        column: x => x.UserId,
                        principalTable: "userloginnews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    BookName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Image = table.Column<string>(type: "varchar(Max)", nullable: true),
                    photoId = table.Column<int>(nullable: true),
                    Uploadedon = table.Column<DateTime>(nullable: false),
                    UId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookDetails_userloginnews_UId",
                        column: x => x.UId,
                        principalTable: "userloginnews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookDetails_Photos_photoId",
                        column: x => x.photoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_photoId",
                table: "books",
                column: "photoId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_UId",
                table: "BookDetails",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_photoId",
                table: "BookDetails",
                column: "photoId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_Photos_photoId",
                table: "books",
                column: "photoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_Photos_photoId",
                table: "books");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_books_photoId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "BookName",
                table: "books");

            migrationBuilder.DropColumn(
                name: "Uploadedon",
                table: "books");

            migrationBuilder.DropColumn(
                name: "photoId",
                table: "books");
        }
    }
}
