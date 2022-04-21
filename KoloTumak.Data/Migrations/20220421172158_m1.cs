using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoloTumak.Data.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventsAllUser",
                columns: table => new
                {
                    IdEvents = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameSurnameResponsiblePerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsAllUser", x => x.IdEvents);
                });

            migrationBuilder.CreateTable(
                name: "HuntingBook",
                columns: table => new
                {
                    IdHunting = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorizationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamePlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateHuntingStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateHuntingEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntingBook", x => x.IdHunting);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                columns: table => new
                {
                    IdStrony = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => x.IdStrony);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    IdNews = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPosition = table.Column<int>(type: "int", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameSurnameAdd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.IdNews);
                });

            migrationBuilder.CreateTable(
                name: "HuntersList",
                columns: table => new
                {
                    IdHunters = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    IdHunting = table.Column<int>(type: "int", nullable: false),
                    HuntingBookIdHunting = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntersList", x => x.IdHunters);
                    table.ForeignKey(
                        name: "FK_HuntersList_HuntingBook_HuntingBookIdHunting",
                        column: x => x.HuntingBookIdHunting,
                        principalTable: "HuntingBook",
                        principalColumn: "IdHunting",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuntersList_HuntingBookIdHunting",
                table: "HuntersList",
                column: "HuntingBookIdHunting");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventsAllUser");

            migrationBuilder.DropTable(
                name: "HuntersList");

            migrationBuilder.DropTable(
                name: "Main");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "HuntingBook");
        }
    }
}
