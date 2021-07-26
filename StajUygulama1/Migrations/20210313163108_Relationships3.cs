using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class Relationships3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HastaBilgileri_AdresIletisimBilgileri_AdresIletisimBilgiId",
                table: "HastaBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_HastaBilgileri_HastaKabulBilgileri_HastaKabulBilgiId",
                table: "HastaBilgileri");

            migrationBuilder.AlterColumn<int>(
                name: "HastaKabulBilgiId",
                table: "HastaBilgileri",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdresIletisimBilgiId",
                table: "HastaBilgileri",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HastaBilgileri_AdresIletisimBilgileri_AdresIletisimBilgiId",
                table: "HastaBilgileri",
                column: "AdresIletisimBilgiId",
                principalTable: "AdresIletisimBilgileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HastaBilgileri_HastaKabulBilgileri_HastaKabulBilgiId",
                table: "HastaBilgileri",
                column: "HastaKabulBilgiId",
                principalTable: "HastaKabulBilgileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HastaBilgileri_AdresIletisimBilgileri_AdresIletisimBilgiId",
                table: "HastaBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_HastaBilgileri_HastaKabulBilgileri_HastaKabulBilgiId",
                table: "HastaBilgileri");

            migrationBuilder.AlterColumn<int>(
                name: "HastaKabulBilgiId",
                table: "HastaBilgileri",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AdresIletisimBilgiId",
                table: "HastaBilgileri",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
