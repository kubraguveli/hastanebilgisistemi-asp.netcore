using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class AdresIlce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IlceId",
                table: "AdresIletisimBilgileri",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IlceninId",
                table: "AdresIletisimBilgileri",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdresIletisimBilgileri_IlceId",
                table: "AdresIletisimBilgileri",
                column: "IlceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdresIletisimBilgileri_Ilceler_IlceId",
                table: "AdresIletisimBilgileri",
                column: "IlceId",
                principalTable: "Ilceler",
                principalColumn: "IlceId",
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

            migrationBuilder.DropColumn(
                name: "IlceninId",
                table: "AdresIletisimBilgileri");
        }
    }
}
