using System.Collections.Generic;

namespace HastaOtomasyonLib
{
    public class Context
    {
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public List<Hasta> Hastalar { get; set; } = new List<Hasta>();
        public List<Personel> Personeller { get; set; } = new List<Personel>();
        public List<Randevu> Randevular { get; set; } = new List<Randevu>();
    }
}
