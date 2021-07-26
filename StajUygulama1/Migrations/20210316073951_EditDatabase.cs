using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class EditDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdresIletisimBilgileri_Ilceler_IlceId",
                table: "AdresIletisimBilgileri");

            migrationBuilder.DropTable(
                name: "Ilceler");

            migrationBuilder.DropTable(
                name: "Iller");

            migrationBuilder.DropIndex(
                name: "IX_AdresIletisimBilgileri_IlceId",
                table: "AdresIletisimBilgileri");

            migrationBuilder.DropColumn(
                name: "IlceId",
                table: "AdresIletisimBilgileri");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IlceId",
                table: "AdresIletisimBilgileri",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Iller",
                columns: table => new
                {
                    IlId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IlAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iller", x => x.IlId);
                });

            migrationBuilder.CreateTable(
                name: "Ilceler",
                columns: table => new
                {
                    IlceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IlId = table.Column<int>(nullable: false),
                    IlceAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilceler", x => x.IlceId);
                    table.ForeignKey(
                        name: "FK_Ilceler_Iller_IlId",
                        column: x => x.IlId,
                        principalTable: "Iller",
                        principalColumn: "IlId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdresIletisimBilgileri_IlceId",
                table: "AdresIletisimBilgileri",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilceler_IlId",
                table: "Ilceler",
                column: "IlId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdresIletisimBilgileri_Ilceler_IlceId",
                table: "AdresIletisimBilgileri",
                column: "IlceId",
                principalTable: "Ilceler",
                principalColumn: "IlceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
