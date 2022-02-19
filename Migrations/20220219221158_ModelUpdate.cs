using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetAtlas.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Reply",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reply",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Comment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reply_UserId",
                table: "Reply",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_User_UserId",
                table: "Reply",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction );
        }
        //ReferentialAction.Cascade
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reply_User_UserId",
                table: "Reply");

            migrationBuilder.DropIndex(
                name: "IX_Reply_UserId",
                table: "Reply");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Reply");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reply");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Comment");
        }
    }
}
