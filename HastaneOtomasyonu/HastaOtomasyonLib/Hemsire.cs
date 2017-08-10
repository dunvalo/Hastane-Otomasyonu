using System;

namespace HastaOtomasyonLib
{
    public class Hemsire : Insan, IMaas
    {
        private DateTime _dogumTarihi;
        public SaglıkBranslar Brans { get; set; }
        public decimal Maas { get; set; }
        public string DoktorId { get; set; } = null;
        public override DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                TimeSpan aralik = DateTime.Now - value;
                double yil = aralik.TotalDays / 365;
                int _yas = (int)yil;
                if (yil > 15)
                    _dogumTarihi = value;
                else
                    throw new Exception("16 yaşından küçük hemşire sisteme kaydedilemez.");
            }
        }
        public override string ToString()
        {
            return base.ToString() + $" {Brans}";
        }
    }
}
