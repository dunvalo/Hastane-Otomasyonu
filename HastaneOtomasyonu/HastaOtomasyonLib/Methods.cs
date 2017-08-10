using System.Collections.Generic;
using System.Linq;

namespace HastaOtomasyonLib
{
    public class Methods
    {
        public static List<Hemsire> Ara(List<Hemsire> Hemsireler, string kelime)
        {
            List<Hemsire> sonuclar = new List<Hemsire>();
            sonuclar = Hemsireler.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.TCKN.ToLower().Contains(kelime.ToLower())).ToList();
            return sonuclar;
        }
        public static List<Doktor> Ara(List<Doktor> Doktorlar, string kelime)
        {
            List<Doktor> sonuclar = new List<Doktor>();

            sonuclar = Doktorlar.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.TCKN.ToLower().Contains(kelime.ToLower())).ToList();
            return sonuclar;
        }
        public static List<Personel> Ara(List<Personel> Personeller, string kelime)
        {
            List<Personel> sonuclar = new List<Personel>();

            sonuclar = Personeller.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.TCKN.ToLower().Contains(kelime.ToLower())).ToList();
            return sonuclar;
        }
        public static List<Hasta> Ara(List<Hasta> Hastalar, string kelime)
        {
            List<Hasta> sonuclar = new List<Hasta>();

            sonuclar = Hastalar.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.TCKN.ToLower().Contains(kelime.ToLower())).ToList();
            return sonuclar;
        }
    }
}
