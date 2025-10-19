using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DanaBet.Migrations
{
    /// <inheritdoc />
    public partial class maketableGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeagueGroups_leagueLevels_LeagueLevelsId",
                table: "LeagueGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_leagueGroupsUsers_LeagueGroups_LeagueGroupsId",
                table: "leagueGroupsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_leagueLevels_Leagues_LeaguesId",
                table: "leagueLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_Leagues_Games_GamesId",
                table: "Leagues");

            migrationBuilder.DropForeignKey(
                name: "FK_LeagueScores_leagueGroupsUsers_LeagueGroupsUsersId",
                table: "LeagueScores");

            migrationBuilder.DropForeignKey(
                name: "FK_LeagueUsers_Leagues_LeaguesId",
                table: "LeagueUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_LeagueUsers_Users_UsersId",
                table: "LeagueUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeagueUsers",
                table: "LeagueUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeagueScores",
                table: "LeagueScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leagues",
                table: "Leagues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_leagueLevels",
                table: "leagueLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_leagueGroupsUsers",
                table: "leagueGroupsUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeagueGroups",
                table: "LeagueGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "TBL_Users");

            migrationBuilder.RenameTable(
                name: "LeagueUsers",
                newName: "TBL_LeagueUsers");

            migrationBuilder.RenameTable(
                name: "LeagueScores",
                newName: "TBL_LeagueScores");

            migrationBuilder.RenameTable(
                name: "Leagues",
                newName: "TBL_Leagues");

            migrationBuilder.RenameTable(
                name: "leagueLevels",
                newName: "TBL_LeagueLevels");

            migrationBuilder.RenameTable(
                name: "leagueGroupsUsers",
                newName: "TBL_LeagueGroupsUsers");

            migrationBuilder.RenameTable(
                name: "LeagueGroups",
                newName: "TBL_LeagueGroups");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "TBL_Games");

            migrationBuilder.RenameIndex(
                name: "IX_LeagueUsers_UsersId",
                table: "TBL_LeagueUsers",
                newName: "IX_TBL_LeagueUsers_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_LeagueUsers_LeaguesId",
                table: "TBL_LeagueUsers",
                newName: "IX_TBL_LeagueUsers_LeaguesId");

            migrationBuilder.RenameIndex(
                name: "IX_LeagueScores_LeagueGroupsUsersId",
                table: "TBL_LeagueScores",
                newName: "IX_TBL_LeagueScores_LeagueGroupsUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Leagues_GamesId",
                table: "TBL_Leagues",
                newName: "IX_TBL_Leagues_GamesId");

            migrationBuilder.RenameIndex(
                name: "IX_leagueLevels_LeaguesId",
                table: "TBL_LeagueLevels",
                newName: "IX_TBL_LeagueLevels_LeaguesId");

            migrationBuilder.RenameIndex(
                name: "IX_leagueGroupsUsers_LeagueGroupsId",
                table: "TBL_LeagueGroupsUsers",
                newName: "IX_TBL_LeagueGroupsUsers_LeagueGroupsId");

            migrationBuilder.RenameIndex(
                name: "IX_LeagueGroups_LeagueLevelsId",
                table: "TBL_LeagueGroups",
                newName: "IX_TBL_LeagueGroups_LeagueLevelsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_Users",
                table: "TBL_Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_LeagueUsers",
                table: "TBL_LeagueUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_LeagueScores",
                table: "TBL_LeagueScores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_Leagues",
                table: "TBL_Leagues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_LeagueLevels",
                table: "TBL_LeagueLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_LeagueGroupsUsers",
                table: "TBL_LeagueGroupsUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_LeagueGroups",
                table: "TBL_LeagueGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_Games",
                table: "TBL_Games",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueGroups_TBL_LeagueLevels_LeagueLevelsId",
                table: "TBL_LeagueGroups",
                column: "LeagueLevelsId",
                principalTable: "TBL_LeagueLevels",
                principalColumn: "Id");

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
                name: "FK_TBL_Leagues_TBL_Games_GamesId",
                table: "TBL_Leagues",
                column: "GamesId",
                principalTable: "TBL_Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_LeagueScores_TBL_LeagueGroupsUsers_LeagueGroupsUsersId",
                table: "TBL_LeagueScores",
                column: "LeagueGroupsUsersId",
                principalTable: "TBL_LeagueGroupsUsers",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueGroups_TBL_LeagueLevels_LeagueLevelsId",
                table: "TBL_LeagueGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueGroupsUsers_TBL_LeagueGroups_LeagueGroupsId",
                table: "TBL_LeagueGroupsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueLevels_TBL_Leagues_LeaguesId",
                table: "TBL_LeagueLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_Leagues_TBL_Games_GamesId",
                table: "TBL_Leagues");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueScores_TBL_LeagueGroupsUsers_LeagueGroupsUsersId",
                table: "TBL_LeagueScores");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueUsers_TBL_Leagues_LeaguesId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_LeagueUsers_TBL_Users_UsersId",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_Users",
                table: "TBL_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_LeagueUsers",
                table: "TBL_LeagueUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_LeagueScores",
                table: "TBL_LeagueScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_Leagues",
                table: "TBL_Leagues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_LeagueLevels",
                table: "TBL_LeagueLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_LeagueGroupsUsers",
                table: "TBL_LeagueGroupsUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_LeagueGroups",
                table: "TBL_LeagueGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_Games",
                table: "TBL_Games");

            migrationBuilder.RenameTable(
                name: "TBL_Users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "TBL_LeagueUsers",
                newName: "LeagueUsers");

            migrationBuilder.RenameTable(
                name: "TBL_LeagueScores",
                newName: "LeagueScores");

            migrationBuilder.RenameTable(
                name: "TBL_Leagues",
                newName: "Leagues");

            migrationBuilder.RenameTable(
                name: "TBL_LeagueLevels",
                newName: "leagueLevels");

            migrationBuilder.RenameTable(
                name: "TBL_LeagueGroupsUsers",
                newName: "leagueGroupsUsers");

            migrationBuilder.RenameTable(
                name: "TBL_LeagueGroups",
                newName: "LeagueGroups");

            migrationBuilder.RenameTable(
                name: "TBL_Games",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_LeagueUsers_UsersId",
                table: "LeagueUsers",
                newName: "IX_LeagueUsers_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_LeagueUsers_LeaguesId",
                table: "LeagueUsers",
                newName: "IX_LeagueUsers_LeaguesId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_LeagueScores_LeagueGroupsUsersId",
                table: "LeagueScores",
                newName: "IX_LeagueScores_LeagueGroupsUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_Leagues_GamesId",
                table: "Leagues",
                newName: "IX_Leagues_GamesId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_LeagueLevels_LeaguesId",
                table: "leagueLevels",
                newName: "IX_leagueLevels_LeaguesId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_LeagueGroupsUsers_LeagueGroupsId",
                table: "leagueGroupsUsers",
                newName: "IX_leagueGroupsUsers_LeagueGroupsId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_LeagueGroups_LeagueLevelsId",
                table: "LeagueGroups",
                newName: "IX_LeagueGroups_LeagueLevelsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeagueUsers",
                table: "LeagueUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeagueScores",
                table: "LeagueScores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leagues",
                table: "Leagues",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_leagueLevels",
                table: "leagueLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_leagueGroupsUsers",
                table: "leagueGroupsUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeagueGroups",
                table: "LeagueGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeagueGroups_leagueLevels_LeagueLevelsId",
                table: "LeagueGroups",
                column: "LeagueLevelsId",
                principalTable: "leagueLevels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_leagueGroupsUsers_LeagueGroups_LeagueGroupsId",
                table: "leagueGroupsUsers",
                column: "LeagueGroupsId",
                principalTable: "LeagueGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_leagueLevels_Leagues_LeaguesId",
                table: "leagueLevels",
                column: "LeaguesId",
                principalTable: "Leagues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Leagues_Games_GamesId",
                table: "Leagues",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeagueScores_leagueGroupsUsers_LeagueGroupsUsersId",
                table: "LeagueScores",
                column: "LeagueGroupsUsersId",
                principalTable: "leagueGroupsUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeagueUsers_Leagues_LeaguesId",
                table: "LeagueUsers",
                column: "LeaguesId",
                principalTable: "Leagues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeagueUsers_Users_UsersId",
                table: "LeagueUsers",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
