using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class integratingph : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Photos_photoId",
                table: "BookDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_userloginnews_UserId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_UserId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_photoId",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "photoId",
                table: "BookDetails");

            migrationBuilder.AddColumn<int>(
                name: "BId",
                table: "Photos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BId",
                table: "Photos",
                column: "BId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_BookDetails_BId",
                table: "Photos",
                column: "BId",
                principalTable: "BookDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_BookDetails_BId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_BId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "BId",
                table: "Photos");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "photoId",
                table: "BookDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_photoId",
                table: "BookDetails",
                column: "photoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Photos_photoId",
                table: "BookDetails",
                column: "photoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_userloginnews_UserId",
                table: "Photos",
                column: "UserId",
                principalTable: "userloginnews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
