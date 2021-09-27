using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class changepasswordtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Password", "UserLogins");
            migrationBuilder.AddColumn<byte[]>(
                name: "Password",
                table: "UserLogins",
                nullable: false,
                defaultValue:"Pass@123"
                //oldClrType: typeof(string),
                //oldType: "nvarchar(max)"
                );

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordKey",
                table: "UserLogins",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordKey",
                table: "UserLogins");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(byte[]));
        }
    }
}
