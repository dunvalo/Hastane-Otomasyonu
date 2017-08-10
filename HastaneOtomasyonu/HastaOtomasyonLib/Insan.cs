using System;
using System.Globalization;

namespace HastaOtomasyonLib
{
    public abstract class Insan
    {
        #region Fields
        private string _ad, _soyad, _telefon;
        #endregion
        #region Properties
        public string Ad
        {
            get { return _ad; }
            set { _ad = AdSoyadHazirla(value); }
        }
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = AdSoyadHazirla(value); }
        }
        public string TCKN { get; set; }
        public Insan()
        {
            string tckn = string.Empty;
            do
            {
                string guid = Guid.NewGuid().ToString().Replace("-", "");
                foreach (char item in guid)
                {
                    if (tckn.Length == 11) break;
                    if (char.IsDigit(item))
                        tckn += item;
                }
            } while (tckn.Length != 11);
            TCKN = tckn;
        }
        public string Telefon
        {
            get { return _telefon; }
            set
            {
                if (value.Length != 10)
                    throw new Exception("Telefon numarasını hatalı girdiniz");
                foreach (char item in value)
                {
                    if (!char.IsDigit(item))
                        throw new Exception("Telefon içerisinde sadece rakam bulunmalıdır");
                }
                _telefon = value;
            }
        }
        public abstract DateTime DogumTarihi { get; set; }
        public int Yas { get { return YasHesapla(); } }
        public Cinsiyetler Cinsiyet { get; set; }
        private string AdSoyadHazirla(string kelime)
        {
            foreach (char harf in kelime)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception("Ad veya Soyad içerisinde geçersiz karakter kullandınız.");
            }
            if (kelime.Trim().Length < 2)
                throw new Exception("Ad ve Soyad en az 2 karakter olmalı");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kelime);
        }
        #endregion
        #region Methods
        private int YasHesapla()
        {
            return DateTime.Now.Year - DogumTarihi.Year;
        } 
        #endregion
        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }
    public enum Cinsiyetler { Kadın, Erkek }
}
