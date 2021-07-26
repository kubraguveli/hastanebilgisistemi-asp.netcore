using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdresIletisimBilgiId",
                table: "HastaBilgileri",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HastaKabulBilgiId",
                table: "HastaBilgileri",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HastaBilgileri_AdresIletisimBilgiId",
                table: "HastaBilgileri",
                column: "AdresIletisimBilgiId");

            migrationBuilder.CreateIndex(
                name: "IX_HastaBilgileri_HastaKabulBilgiId",
                table: "HastaBilgileri",
                column: "HastaKabulBilgiId");

            migrationBuilder.AddForeignKey(
                name: "FK_HastaBilgileri_AdresIletisimBilgileri_AdresIletisimBilgiId",
                table: "HastaBilgileri",
                column: "AdresIletisimBilgiId",
                principalTable: "AdresIletisimBilgileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HastaBilgileri_HastaKabulBilgileri_HastaKabulBilgiId",
                table: "HastaBilgileri",
                column: "HastaKabulBilgiId",
                principalTable: "HastaKabulBilgileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HastaBilgileri_AdresIletisimBilgileri_AdresIletisimBilgiId",
                table: "HastaBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_HastaBilgileri_HastaKabulBilgileri_HastaKabulBilgiId",
                table: "HastaBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_HastaBilgileri_AdresIletisimBilgiId",
                table: "HastaBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_HastaBilgileri_HastaKabulBilgiId",
                table: "HastaBilgileri");

            migrationBuilder.DropColumn(
                name: "AdresIletisimBilgiId",
                table: "HastaBilgileri");

            migrationBuilder.DropColumn(
                name: "HastaKabulBilgiId",
                table: "HastaBilgileri");
        }
    }
}
