using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoloTumak.Data.Migrations
{
    public partial class m8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameSiteHeader",
                table: "EditWWW");

            migrationBuilder.CreateTable(
                name: "HeaderSiteName",
                columns: table => new
                {
                    IdSiteHeader = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSiteHeader = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderSiteName", x => x.IdSiteHeader);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeaderSiteName");

            migrationBuilder.AddColumn<string>(
                name: "NameSiteHeader",
                table: "EditWWW",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
