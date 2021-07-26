using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class EditAdresIletisimBilgi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ilce",
                table: "AdresIletisimBilgileri",
                newName: "IlceAd");

            migrationBuilder.RenameColumn(
                name: "Il",
                table: "AdresIletisimBilgileri",
                newName: "IlAd");

            migrationBuilder.AddColumn<int>(
                name: "IlceId",
                table: "AdresIletisimBilgileri",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdresIletisimBilgileri_IlceId",
                table: "AdresIletisimBilgileri",
                column: "IlceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdresIletisimBilgileri_Ilceler_IlceId",
                table: "AdresIletisimBilgileri",
                column: "IlceId",
                principalTable: "Ilceler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdresIletisimBilgileri_Ilceler_IlceId",
                table: "AdresIletisimBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_AdresIletisimBilgileri_IlceId",
                table: "AdresIletisimBilgileri");

            migrationBuilder.DropColumn(
                name: "IlceId",
                table: "AdresIletisimBilgileri");

            migrationBuilder.RenameColumn(
                name: "IlceAd",
                table: "AdresIletisimBilgileri",
                newName: "Ilce");

            migrationBuilder.RenameColumn(
                name: "IlAd",
                table: "AdresIletisimBilgileri",
                newName: "Il");
        }
    }
}
