using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoloTumak.Intranet.Migrations
{
    public partial class InitialCreate : Migration
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
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NameSurnameResponsiblePerson = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Contact = table.Column<int>(type: "int", maxLength: 22, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsAllUser", x => x.IdEvents);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventsAllUser");

            migrationBuilder.DropTable(
                name: "Main");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
