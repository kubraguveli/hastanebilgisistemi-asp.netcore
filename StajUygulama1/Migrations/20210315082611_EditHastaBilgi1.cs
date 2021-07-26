using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class EditHastaBilgi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MuracaatTarihi",
                table: "HastaBilgileri",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "MuracaatTarihi",
                table: "HastaBilgileri",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
