using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KoloTumak.Data.Migrations
{
    public partial class m7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameSiteHeader",
                table: "EditWWW",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameSiteHeader",
                table: "EditWWW");
        }
    }
}
