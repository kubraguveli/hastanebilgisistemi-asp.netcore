using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1.Models
{
    public class AdresIletisimBilgi
    {
        public int Id { get; set; }
        public string AdresTuru { get; set; }
        public string IlAd { get; set; }
        public string IlceAd { get; set; }
        public string TelefonTuru { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }

        public IEnumerable<HastaBilgi> HastaBilgileri { get; set; }
        
        public int IlceninId { get; set; }
        public Ilce Ilce { get; set; }
      
    }
}
