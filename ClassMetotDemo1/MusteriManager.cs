using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public string MusteriEkle(Musteri musteri)
        {
            return $"Sayın {musteri.Ad} {musteri.Soyad} {musteri.HesapNo} nolu hesabınız eklenmiştir.";
        }

        public string MusteriSil(Musteri musteri)
        {
            return $"Hesap {musteri.Ad} {musteri.Soyad} {musteri.Adres} ve {musteri.HesapNo} nolu hesabınız silinmiştir.";
        }
    }
}
