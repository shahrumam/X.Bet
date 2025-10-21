using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DanaBet.Migrations
{
    /// <inheritdoc />
    public partial class updatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueGroupsUsers_TBL_LeagueGroups_LeagueGroupsId",
                table: "TBL_LeagueGroupsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueLevels_TBL_Leagues_LeaguesId",
                table: "TBL_LeagueLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueUsers_TBL_Leagues_LeaguesId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueUsers_TBL_Users_UsersId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropIndex(
                name: "IX_TBL_LeagueUsers_LeaguesId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropIndex(
                name: "IX_TBL_LeagueUsers_UsersId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropIndex(
                name: "IX_TBL_LeagueLevels_LeaguesId",
                table: "TBL_LeagueLevels");

            migrationBuilder.DropIndex(
                name: "IX_TBL_LeagueGroupsUsers_LeagueGroupsId",
                table: "TBL_LeagueGroupsUsers");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "TBL_Users");

            migrationBuilder.DropColumn(
                name: "LeaguesId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropColumn(
                name: "LeaguesId",
                table: "TBL_LeagueLevels");

            migrationBuilder.DropColumn(
                name: "LeagueGroupsId",
                table: "TBL_LeagueGroupsUsers");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "TBL_Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "TBL_Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TBL_LeagueGroupsUsers",
                newName: "LeagueUserId");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "TBL_LeagueUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "TBL_LeagueUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "TBL_LeagueUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LeagueUsers_LeagueId",
                table: "TBL_LeagueUsers",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LeagueLevels_LeagueId",
                table: "TBL_LeagueLevels",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LeagueGroupsUsers_LeagueGroupId",
                table: "TBL_LeagueGroupsUsers",
                column: "LeagueGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LeagueGroupsUsers_LeagueUserId",
                table: "TBL_LeagueGroupsUsers",
                column: "LeagueUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueGroupsUsers_TBL_LeagueGroups_LeagueGroupId",
                table: "TBL_LeagueGroupsUsers",
                column: "LeagueGroupId",
                principalTable: "TBL_LeagueGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueGroupsUsers_TBL_LeagueUsers_LeagueUserId",
                table: "TBL_LeagueGroupsUsers",
                column: "LeagueUserId",
                principalTable: "TBL_LeagueUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueLevels_TBL_Leagues_LeagueId",
                table: "TBL_LeagueLevels",
                column: "LeagueId",
                principalTable: "TBL_Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueUsers_TBL_Leagues_LeagueId",
                table: "TBL_LeagueUsers",
                column: "LeagueId",
                principalTable: "TBL_Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueGroupsUsers_TBL_LeagueGroups_LeagueGroupId",
                table: "TBL_LeagueGroupsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueGroupsUsers_TBL_LeagueUsers_LeagueUserId",
                table: "TBL_LeagueGroupsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueLevels_TBL_Leagues_LeagueId",
                table: "TBL_LeagueLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueUsers_TBL_Leagues_LeagueId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropIndex(
                name: "IX_TBL_LeagueUsers_LeagueId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropIndex(
                name: "IX_TBL_LeagueLevels_LeagueId",
                table: "TBL_LeagueLevels");

            migrationBuilder.DropIndex(
                name: "IX_TBL_LeagueGroupsUsers_LeagueGroupId",
                table: "TBL_LeagueGroupsUsers");

            migrationBuilder.DropIndex(
                name: "IX_TBL_LeagueGroupsUsers_LeagueUserId",
                table: "TBL_LeagueGroupsUsers");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "TBL_LeagueUsers");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "TBL_Users",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "TBL_Users",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "LeagueUserId",
                table: "TBL_LeagueGroupsUsers",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "TBL_Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LeaguesId",
                table: "TBL_LeagueUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "TBL_LeagueUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "TBL_LeagueUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeaguesId",
                table: "TBL_LeagueLevels",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeagueGroupsId",
                table: "TBL_LeagueGroupsUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LeagueUsers_LeaguesId",
                table: "TBL_LeagueUsers",
                column: "LeaguesId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LeagueUsers_UsersId",
                table: "TBL_LeagueUsers",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LeagueLevels_LeaguesId",
                table: "TBL_LeagueLevels",
                column: "LeaguesId");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_LeagueGroupsUsers_LeagueGroupsId",
                table: "TBL_LeagueGroupsUsers",
                column: "LeagueGroupsId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueGroupsUsers_TBL_LeagueGroups_LeagueGroupsId",
                table: "TBL_LeagueGroupsUsers",
                column: "LeagueGroupsId",
                principalTable: "TBL_LeagueGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueLevels_TBL_Leagues_LeaguesId",
                table: "TBL_LeagueLevels",
                column: "LeaguesId",
                principalTable: "TBL_Leagues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueUsers_TBL_Leagues_LeaguesId",
                table: "TBL_LeagueUsers",
                column: "LeaguesId",
                principalTable: "TBL_Leagues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueUsers_TBL_Users_UsersId",
                table: "TBL_LeagueUsers",
                column: "UsersId",
                principalTable: "TBL_Users",
                principalColumn: "Id");
        }
    }
}
