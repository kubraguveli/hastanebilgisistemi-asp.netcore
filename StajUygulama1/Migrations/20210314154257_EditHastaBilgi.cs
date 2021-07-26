using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class EditHastaBilgi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DogumTarihi",
                table: "HastaBilgileri",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MuracaatTarihi",
                table: "HastaBilgileri",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MuracaatTarihi",
                table: "HastaBilgileri");

            migrationBuilder.AlterColumn<string>(
                name: "DogumTarihi",
                table: "HastaBilgileri",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
