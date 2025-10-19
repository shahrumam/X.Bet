using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DanaBet.Migrations
{
    /// <inheritdoc />
    public partial class minorchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_Leagues_TBL_Games_GamesId",
                table: "TBL_Leagues");

            migrationBuilder.DropIndex(
                name: "IX_TBL_Leagues_GamesId",
                table: "TBL_Leagues");

            migrationBuilder.DropColumn(
                name: "GamesId",
                table: "TBL_Leagues");

            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "TBL_Games",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "TBL_Games",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Leagues_GameId",
                table: "TBL_Leagues",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_Leagues_TBL_Games_GameId",
                table: "TBL_Leagues",
                column: "GameId",
                principalTable: "TBL_Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_Leagues_TBL_Games_GameId",
                table: "TBL_Leagues");

            migrationBuilder.DropIndex(
                name: "IX_TBL_Leagues_GameId",
                table: "TBL_Leagues");

            migrationBuilder.AddColumn<int>(
                name: "GamesId",
                table: "TBL_Leagues",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "TBL_Games",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "TBL_Games",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Leagues_GamesId",
                table: "TBL_Leagues",
                column: "GamesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_Leagues_TBL_Games_GamesId",
                table: "TBL_Leagues",
                column: "GamesId",
                principalTable: "TBL_Games",
                principalColumn: "Id");
        }
    }
}
