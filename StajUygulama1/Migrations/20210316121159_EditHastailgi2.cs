using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class EditHastailgi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SilinmeTarih",
                table: "HastaBilgileri",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SilinmeTarih",
                table: "HastaBilgileri");
        }
    }
}
