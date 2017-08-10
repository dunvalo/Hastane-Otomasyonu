using System;

namespace HastaOtomasyonLib
{
    public class Personel : Insan, IMaas
    {
        private DateTime _dogumTarihi;
        public PersonelBranslar PersonelBrans { get; set; }
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
                    throw new Exception("18 yaşından küçük personeler sisteme kaydedilemez.");
            }
        }
        public decimal Maas { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" {PersonelBrans}";
        }
    }
    public enum PersonelBranslar
    {
        Temizlikci,
        Muhasebe,
        Aşcı,
        HastaBakıcı,
        Güvenlik
    }
}
