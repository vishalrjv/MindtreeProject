using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class integratin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_userloginnews_UId",
                table: "BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_Photos_BId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_UId",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "UId",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "Uploadedon",
                table: "BookDetails");

            migrationBuilder.AddColumn<int>(
                name: "userloginnewId",
                table: "BookDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BId",
                table: "Photos",
                column: "BId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_userloginnewId",
                table: "BookDetails",
                column: "userloginnewId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_userloginnews_userloginnewId",
                table: "BookDetails",
                column: "userloginnewId",
                principalTable: "userloginnews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_userloginnews_userloginnewId",
                table: "BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_Photos_BId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_userloginnewId",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "userloginnewId",
                table: "BookDetails");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "BookDetails",
                type: "varchar(Max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UId",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Uploadedon",
                table: "BookDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BId",
                table: "Photos",
                column: "BId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_UId",
                table: "BookDetails",
                column: "UId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_userloginnews_UId",
                table: "BookDetails",
                column: "UId",
                principalTable: "userloginnews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
