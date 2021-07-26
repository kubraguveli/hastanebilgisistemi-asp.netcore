using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1.Models
{
    public class HastaKabulBilgi
    {
        public int Id { get; set; }

        public string TakipBilgisi { get; set; }
        public string HastaSinifi { get; set; }
        public string Kurumu { get; set; }
        public string KabulSekli { get; set; }
        public string SigortaTuru { get; set; }
        public string VakaTipi { get; set; }
        public string OncelikDurumu { get; set; }
        public string Yakınlık { get; set; }
        public string OdemeTuru { get; set; }
        public string SonGelisTarihi { get; set; }
        public string Servis { get; set; }
        public string Doktor { get; set; }
        public string TriajBeyani { get; set; }
        public string Aciklama { get; set; }

        public IEnumerable<HastaBilgi> HastaBilgileri { get; set; }
    }
}
