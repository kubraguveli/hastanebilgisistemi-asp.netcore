using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1.Models
{
    public interface IHastaBilgiRepository
    {
        IEnumerable<Il> Iller { get; }
        IEnumerable<Ilce> Ilceler { get; }
        IEnumerable<HastaBilgi> HastaBilgileri { get; }
        IEnumerable<AdresIletisimBilgi> AdresIletisimBilgileri { get;  }

        IEnumerable<HastaKabulBilgi> HastaKabulBilgileri { get; }
        /// <summary>
        /// Dışarıdan hastaid parametresi alıp geriye Hasta bilgi nesnesi döndüren metot
        /// </summary>
        /// <param name="hastaid"></param>
        /// <returns></returns>
        HastaBilgi GetById(int hastaid);

        /// <summary>
        /// Gönderilen parametrelere uygun olan hastabilgilerini getirir.
        /// </summary>
        /// <param name="tcno"></param>
        /// <param name="ad"></param>
        /// <param name="soyad"></param>
        /// <returns></returns>
        IEnumerable<HastaBilgi> GetHastaBilgileriByFilters(string tcno = null, string ad = null, string soyad = null);
        int AddHastaBilgi(HastaBilgi newHasta);
       

        void UpdateHastaBilgi(HastaBilgi updateHasta, HastaBilgi originalHasta = null);
        void DeleteHastaBilgi(int hastaid);
    }
}
