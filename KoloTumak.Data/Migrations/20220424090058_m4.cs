using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoloTumak.Data.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NavSite");

            migrationBuilder.CreateTable(
                name: "EditWWW",
                columns: table => new
                {
                    IdPosition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameNavSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameSite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditWWW", x => x.IdPosition);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditWWW");

            migrationBuilder.CreateTable(
                name: "NavSite",
                columns: table => new
                {
                    IdPosition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameNavSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameSite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavSite", x => x.IdPosition);
                });
        }
    }
}
