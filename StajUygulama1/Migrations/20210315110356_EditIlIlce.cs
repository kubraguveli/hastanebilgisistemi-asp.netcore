using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class EditIlIlce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Iller",
                newName: "IlId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ilceler",
                newName: "IlceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IlId",
                table: "Iller",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IlceId",
                table: "Ilceler",
                newName: "Id");
        }
    }
}
