using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StajUygulama1.Migrations
{
    public partial class EditHastaBilgi3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Yas",
                table: "HastaBilgileri",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DogumTarihi",
                table: "HastaBilgileri",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "Kodu",
                table: "HastaBilgileri",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kodu",
                table: "HastaBilgileri");

            migrationBuilder.AlterColumn<int>(
                name: "Yas",
                table: "HastaBilgileri",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DogumTarihi",
                table: "HastaBilgileri",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
