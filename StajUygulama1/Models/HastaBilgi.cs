using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1.Models
{
    public class HastaBilgi
    {
        public int Id { get; set; }
        public int? Kodu { get; set; }
        public string MuracaatTarihi { get; set; }

        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string KimlikNo { get; set; }

        [Required(ErrorMessage = "Boş bırakılamaz")]
        public int DosyaNo { get; set; }

        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string Uyruk { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public int? Yas { get; set; }
        public string SilinmeTarih { get; set; }
      

        public int AdresIletisimBilgiId { get; set; }
        public AdresIletisimBilgi AdresIletisimBilgi { get; set; }

        public int HastaKabulBilgiId { get; set; }
        public HastaKabulBilgi HastaKabulBilgi { get; set; }
    }
}
