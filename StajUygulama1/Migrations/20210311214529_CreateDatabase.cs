using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdresIletisimBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdresTuru = table.Column<string>(nullable: true),
                    Il = table.Column<string>(nullable: true),
                    Ilce = table.Column<string>(nullable: true),
                    TelefonTuru = table.Column<string>(nullable: true),
                    TelefonNo = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdresIletisimBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HastaBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KimlikNo = table.Column<string>(nullable: true),
                    DosyaNo = table.Column<int>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Cinsiyet = table.Column<string>(nullable: true),
                    Uyruk = table.Column<string>(nullable: true),
                    BabaAdi = table.Column<string>(nullable: true),
                    AnneAdi = table.Column<string>(nullable: true),
                    DogumYeri = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<string>(nullable: true),
                    Yas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HastaBilgileri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HastaKabulBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TakipBilgisi = table.Column<string>(nullable: true),
                    HastaSinifi = table.Column<string>(nullable: true),
                    Kurumu = table.Column<string>(nullable: true),
                    KabulSekli = table.Column<string>(nullable: true),
                    SigortaTuru = table.Column<string>(nullable: true),
                    VakaTipi = table.Column<string>(nullable: true),
                    OncelikDurumu = table.Column<string>(nullable: true),
                    Yakınlık = table.Column<string>(nullable: true),
                    OdemeTuru = table.Column<string>(nullable: true),
                    SonGelisTarihi = table.Column<string>(nullable: true),
                    Servis = table.Column<string>(nullable: true),
                    Doktor = table.Column<string>(nullable: true),
                    TriajBeyani = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HastaKabulBilgileri", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdresIletisimBilgileri");

            migrationBuilder.DropTable(
                name: "HastaBilgileri");

            migrationBuilder.DropTable(
                name: "HastaKabulBilgileri");
        }
    }
}
