﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Decidehub.Infrastructure.Migrations
{
    public partial class RemovedVotedUserIdConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_AspNetUsers_VotedUserId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_VotedUserId",
                table: "Votes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Votes_VotedUserId",
                table: "Votes",
                column: "VotedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_AspNetUsers_VotedUserId",
                table: "Votes",
                column: "VotedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
