using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaOtomasyonLib
{
    public class Randevu
    {
        public string HastaAdiSoyadi { get; set; }
        public string DoktorAdiSoyadi { get; set; }
        public string RandevuBransi { get; set; }
        public string Saat { get; set; }
        public string DoktorID { get; set; }
        public string HastaID { get; set; }
        public override string ToString()
        {
            return $"{Saat} - {HastaAdiSoyadi} - {HastaID}";
        }

    }
}
