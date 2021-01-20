using System;
using ClassMetotDemo;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Tekçe";
            musteri1.HesapNo = 123456;
            musteri1.Adres = "Gaziantep";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Yılmaz";
            musteri2.HesapNo = 456123;
            musteri2.Adres = "İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Salih";
            musteri3.Soyad = "Ok";
            musteri3.HesapNo = 123789;
            musteri3.Adres = "Ankara";

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Hakan";
            musteri4.Soyad = "Yılmaz";
            musteri4.HesapNo = 789456;
            musteri4.Adres = "İzmir";

            Musteri musteri5 = new Musteri();
            musteri5.Ad = "Fırat";
            musteri5.Soyad = "Kara";
            musteri5.HesapNo = 789123;
            musteri5.Adres = "Adana";

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine(musteriManager.MusteriEkle(musteri1));
            Aralik();
            Console.WriteLine(musteriManager.MusteriSil(musteri5));
            Aralik();

            foreach (var musteri in musteris)
            {
                Console.WriteLine($"Adı: {musteri.Ad} \nSoyad: {musteri.Soyad} \nAdres: {musteri.Adres} \nMüşteri hesap no: {musteri.HesapNo}");
                Aralik();
            }
        }

        public static void Aralik()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hello World!");
        }
    }
}
