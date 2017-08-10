using System;
using System.Collections.Generic;

namespace HastaOtomasyonLib
{
    public class Doktor : Insan, IMaas
    {
        private DateTime _dogumTarihi;
        public SaglıkBranslar Brans { get; set; }
        public List<Hemsire> BagliHemsireler { get; set; } = new List<Hemsire>();
        public decimal Maas { get; set; }
        public List<string> DoktorunRandevuSaatleri { get; set; }
        public List<Randevu> DoktorunRandevulari { get; set; }
        public override DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                TimeSpan aralik = DateTime.Now - value;
                double yil = aralik.TotalDays / 365;
                int _yas = (int)yil;
                if (yil > 17)
                    _dogumTarihi = value;
                else
                    throw new Exception("18 yaşından küçük doktorlar sisteme kaydedilemez.");
            }
        }
        public override string ToString()
        {
            return $"{Brans} - \n" + base.ToString();
        }
    }
    public enum SaglıkBranslar
    {
        GenelCerrahi, Ortopedi, DişHekimliği, FizikTedavi, Pediatri
    }
}
