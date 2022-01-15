using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecordStore1.Migrations
{
    public partial class name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nom",
                table: "Artistes");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Artistes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Artistes");

            migrationBuilder.AddColumn<string>(
                name: "Nom",
                table: "Artistes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
