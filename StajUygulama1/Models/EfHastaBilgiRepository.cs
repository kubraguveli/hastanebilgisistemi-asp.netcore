using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1.Models
{
    public class EfHastaBilgiRepository : IHastaBilgiRepository
    {
        private DataContext context;

        public EfHastaBilgiRepository(DataContext _context)
        {
            context = _context;

        }

        public IEnumerable<HastaBilgi> HastaBilgileri => context.HastaBilgileri;

        public IEnumerable<AdresIletisimBilgi> AdresIletisimBilgileri => context.AdresIletisimBilgileri;
        public IEnumerable<HastaKabulBilgi> HastaKabulBilgileri => context.HastaKabulBilgileri;

        public IEnumerable<Il> Iller => context.Iller;
        public IEnumerable<Ilce> Ilceler => context.Ilceler;

        public int AddHastaBilgi(HastaBilgi newHasta)
        {
            
            context.HastaBilgileri.Add(newHasta);
            context.SaveChanges();
            return newHasta.Id;
           
        }

        public void DeleteHastaBilgi(int hastaid)
        {
            var entity = GetById(hastaid);

            DateTime bugun = DateTime.Now;
            entity.GetType().GetProperty("SilinmeTarih").SetValue(entity, bugun.ToString());

            context.HastaBilgileri.Update(entity);

            context.SaveChanges();
        }

        public HastaBilgi GetById(int hastaid)
        {
            return context.HastaBilgileri
                .Include(i => i.HastaKabulBilgi)
                .Include(i => i.AdresIletisimBilgi)
                .ThenInclude(i => i.Ilce)
                .ThenInclude(i => i.Il)
                .FirstOrDefault(i => i.Id == hastaid);

        }

        public IEnumerable<HastaBilgi> GetHastaBilgileriByFilters(string tcno = null, string ad = null, string soyad = null)
        {
            IQueryable<HastaBilgi> query = context.HastaBilgileri;

            if (tcno != null)
            {
                query = query.Where(i => i.KimlikNo == tcno);
            }
            if (ad != null)
            {
                query = query.Where(i => i.Ad.ToLower().Contains(ad.ToLower()));
            }
            if (soyad != null)
            {
                query = query.Where(i => i.Soyad.ToLower().Contains(soyad.ToLower()));
            }

            return query.Include(i => i.AdresIletisimBilgi).Include(i => i.HastaKabulBilgi).ToList();
        }


        public void UpdateHastaBilgi(HastaBilgi updateHasta, HastaBilgi originalHasta = null)
        {
            // originalCourse değeri eğer null a eşitse bu durumda veritabanında bilgi seçilir.
            if (originalHasta == null)
            {
                originalHasta = context.HastaBilgileri.Find(originalHasta.Id);
            }
            //Ama eğer değer gönderilmişse seçmeye gerek yok.Tracking başlar ve update sorgusu sadece güncellenenler için çalışır.
            else
            {
                context.HastaBilgileri.Attach(originalHasta);
            }

            originalHasta.KimlikNo = updateHasta.KimlikNo;
            originalHasta.Kodu = updateHasta.Kodu;
            originalHasta.DosyaNo = updateHasta.DosyaNo;
            originalHasta.Ad = updateHasta.Ad;
            originalHasta.Soyad = updateHasta.Soyad;
            originalHasta.Cinsiyet = updateHasta.Cinsiyet;
            originalHasta.Uyruk = updateHasta.Uyruk;
            originalHasta.AnneAdi = updateHasta.AnneAdi;
            originalHasta.BabaAdi = updateHasta.BabaAdi;
            originalHasta.DogumTarihi = updateHasta.DogumTarihi;
            originalHasta.DogumYeri = updateHasta.DogumYeri;
            originalHasta.Yas = updateHasta.Yas;

            originalHasta.AdresIletisimBilgi.AdresTuru = updateHasta.AdresIletisimBilgi.AdresTuru;
            originalHasta.AdresIletisimBilgi.IlAd = updateHasta.AdresIletisimBilgi.IlAd;
            originalHasta.AdresIletisimBilgi.IlceAd = updateHasta.AdresIletisimBilgi.IlceAd;
            originalHasta.AdresIletisimBilgi.TelefonTuru = updateHasta.AdresIletisimBilgi.TelefonTuru;
            originalHasta.AdresIletisimBilgi.TelefonNo = updateHasta.AdresIletisimBilgi.TelefonNo;
            originalHasta.AdresIletisimBilgi.Adres = updateHasta.AdresIletisimBilgi.Adres;

            originalHasta.HastaKabulBilgi.TakipBilgisi = updateHasta.HastaKabulBilgi.TakipBilgisi;
            originalHasta.HastaKabulBilgi.HastaSinifi = updateHasta.HastaKabulBilgi.HastaSinifi;
            originalHasta.HastaKabulBilgi.Kurumu = updateHasta.HastaKabulBilgi.Kurumu;
            originalHasta.HastaKabulBilgi.KabulSekli = updateHasta.HastaKabulBilgi.KabulSekli;
            originalHasta.HastaKabulBilgi.SigortaTuru = updateHasta.HastaKabulBilgi.SigortaTuru;
            originalHasta.HastaKabulBilgi.VakaTipi = updateHasta.HastaKabulBilgi.VakaTipi;
            originalHasta.HastaKabulBilgi.OncelikDurumu = updateHasta.HastaKabulBilgi.OncelikDurumu;
            originalHasta.HastaKabulBilgi.Yakınlık = updateHasta.HastaKabulBilgi.Yakınlık;
            originalHasta.HastaKabulBilgi.OdemeTuru = updateHasta.HastaKabulBilgi.OdemeTuru;
            originalHasta.HastaKabulBilgi.SonGelisTarihi = updateHasta.HastaKabulBilgi.SonGelisTarihi;
            originalHasta.HastaKabulBilgi.Servis = updateHasta.HastaKabulBilgi.Servis;
            originalHasta.HastaKabulBilgi.Doktor = updateHasta.HastaKabulBilgi.Doktor;
            originalHasta.HastaKabulBilgi.TriajBeyani = updateHasta.HastaKabulBilgi.TriajBeyani;
            originalHasta.HastaKabulBilgi.Aciklama = updateHasta.HastaKabulBilgi.Aciklama;

            context.SaveChanges();

        }
    }
}