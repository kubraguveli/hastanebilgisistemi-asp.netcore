﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StajUygulama1.Models;

namespace StajUygulama1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210316073951_EditDatabase")]
    partial class EditDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StajUygulama1.Models.AdresIletisimBilgi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres");

                    b.Property<string>("AdresTuru");

                    b.Property<string>("IlAd");

                    b.Property<string>("IlceAd");

                    b.Property<string>("TelefonNo");

                    b.Property<string>("TelefonTuru");

                    b.HasKey("Id");

                    b.ToTable("AdresIletisimBilgileri");
                });

            modelBuilder.Entity("StajUygulama1.Models.HastaBilgi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad");

                    b.Property<int>("AdresIletisimBilgiId");

                    b.Property<string>("AnneAdi");

                    b.Property<string>("BabaAdi");

                    b.Property<string>("Cinsiyet");

                    b.Property<DateTime>("DogumTarihi");

                    b.Property<string>("DogumYeri");

                    b.Property<int>("DosyaNo");

                    b.Property<int>("HastaKabulBilgiId");

                    b.Property<string>("KimlikNo");

                    b.Property<string>("MuracaatTarihi");

                    b.Property<string>("Soyad");

                    b.Property<string>("Uyruk");

                    b.Property<int>("Yas");

                    b.HasKey("Id");

                    b.HasIndex("AdresIletisimBilgiId");

                    b.HasIndex("HastaKabulBilgiId");

                    b.ToTable("HastaBilgileri");
                });

            modelBuilder.Entity("StajUygulama1.Models.HastaKabulBilgi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama");

                    b.Property<string>("Doktor");

                    b.Property<string>("HastaSinifi");

                    b.Property<string>("KabulSekli");

                    b.Property<string>("Kurumu");

                    b.Property<string>("OdemeTuru");

                    b.Property<string>("OncelikDurumu");

                    b.Property<string>("Servis");

                    b.Property<string>("SigortaTuru");

                    b.Property<string>("SonGelisTarihi");

                    b.Property<string>("TakipBilgisi");

                    b.Property<string>("TriajBeyani");

                    b.Property<string>("VakaTipi");

                    b.Property<string>("Yakınlık");

                    b.HasKey("Id");

                    b.ToTable("HastaKabulBilgileri");
                });

            modelBuilder.Entity("StajUygulama1.Models.HastaBilgi", b =>
                {
                    b.HasOne("StajUygulama1.Models.AdresIletisimBilgi", "AdresIletisimBilgi")
                        .WithMany("HastaBilgileri")
                        .HasForeignKey("AdresIletisimBilgiId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StajUygulama1.Models.HastaKabulBilgi", "HastaKabulBilgi")
                        .WithMany("HastaBilgileri")
                        .HasForeignKey("HastaKabulBilgiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
