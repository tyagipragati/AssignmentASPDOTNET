using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace product.Migrations
{
    public partial class sprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Gasmeter",
                table: "Gasmeter");

            migrationBuilder.RenameTable(
                name: "Gasmeter",
                newName: "liberty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_liberty",
                table: "liberty",
                column: "SerialNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_liberty",
                table: "liberty");

            migrationBuilder.RenameTable(
                name: "liberty",
                newName: "Gasmeter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gasmeter",
                table: "Gasmeter",
                column: "SerialNumber");
        }
    }
}
