using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DanaBet.Migrations
{
    /// <inheritdoc />
    public partial class maketables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Version = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: false),
                    Lastname = table.Column<string>(type: "TEXT", nullable: false),
                    Mobile = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    GameId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MaxUserCount = table.Column<int>(type: "INTEGER", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    GamesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leagues_Games_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "leagueLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<int>(type: "INTEGER", nullable: false),
                    LeagueId = table.Column<int>(type: "INTEGER", nullable: false),
                    LeaguesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leagueLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_leagueLevels_Leagues_LeaguesId",
                        column: x => x.LeaguesId,
                        principalTable: "Leagues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeagueUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    LeagueId = table.Column<int>(type: "INTEGER", nullable: false),
                    LeaguesId = table.Column<int>(type: "INTEGER", nullable: true),
                    UsersId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeagueUsers_Leagues_LeaguesId",
                        column: x => x.LeaguesId,
                        principalTable: "Leagues",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeagueUsers_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeagueGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<int>(type: "INTEGER", nullable: false),
                    LevelId = table.Column<int>(type: "INTEGER", nullable: false),
                    LeagueLevelsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeagueGroups_leagueLevels_LeagueLevelsId",
                        column: x => x.LeagueLevelsId,
                        principalTable: "leagueLevels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "leagueGroupsUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LeagueGroupId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    LeagueGroupsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leagueGroupsUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_leagueGroupsUsers_LeagueGroups_LeagueGroupsId",
                        column: x => x.LeagueGroupsId,
                        principalTable: "LeagueGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LeagueScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LeagueGroupUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MaxUserCount = table.Column<int>(type: "INTEGER", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    LeagueGroupsUsersId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeagueScores_leagueGroupsUsers_LeagueGroupsUsersId",
                        column: x => x.LeagueGroupsUsersId,
                        principalTable: "leagueGroupsUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeagueGroups_LeagueLevelsId",
                table: "LeagueGroups",
                column: "LeagueLevelsId");

            migrationBuilder.CreateIndex(
                name: "IX_leagueGroupsUsers_LeagueGroupsId",
                table: "leagueGroupsUsers",
                column: "LeagueGroupsId");

            migrationBuilder.CreateIndex(
                name: "IX_leagueLevels_LeaguesId",
                table: "leagueLevels",
                column: "LeaguesId");

            migrationBuilder.CreateIndex(
                name: "IX_Leagues_GamesId",
                table: "Leagues",
                column: "GamesId");

            migrationBuilder.CreateIndex(
                name: "IX_LeagueScores_LeagueGroupsUsersId",
                table: "LeagueScores",
                column: "LeagueGroupsUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_LeagueUsers_LeaguesId",
                table: "LeagueUsers",
                column: "LeaguesId");

            migrationBuilder.CreateIndex(
                name: "IX_LeagueUsers_UsersId",
                table: "LeagueUsers",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeagueScores");

            migrationBuilder.DropTable(
                name: "LeagueUsers");

            migrationBuilder.DropTable(
                name: "leagueGroupsUsers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "LeagueGroups");

            migrationBuilder.DropTable(
                name: "leagueLevels");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
