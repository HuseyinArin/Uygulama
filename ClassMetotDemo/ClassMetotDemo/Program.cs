using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = 12;
            musteri1.MusteriAdi = "Hüseyin";
            musteri1.MusteriSoyadi = "Arin";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = 13;
            musteri2.MusteriAdi = "Bilge ";
            musteri2.MusteriSoyadi = "Ökten";



            Musteri musteri3 = new Musteri();
            musteri3.Id =3;
            musteri3.MusteriNo = 14;
            musteri3.MusteriAdi = "Aslan";
            musteri3.MusteriSoyadi = "Aslan";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriNo);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine("-------------------");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            Console.WriteLine("----------------");
            musteriManager.Update(musteri2);
            Console.WriteLine("----------------");
            musteriManager.Delete(musteri3);
            Console.WriteLine("----------------");


        }
    }
}
