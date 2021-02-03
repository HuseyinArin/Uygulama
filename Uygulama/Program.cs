using System;

namespace Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();
            urun.Adi = "elma";
            urun.Fiyat = 12;
            urun.Aciklama = "amasya elması";
            urun.StokAdedi = 21;

            Urun urun1 = new Urun();
            urun1.Adi = "armut";
            urun1.Fiyat = 15;
            urun1.Aciklama = "ankara armutu";
            urun1.StokAdedi = 25;

            Urun[] urunler = new Urun[] {urun,urun1 };

            foreach (Urun urun2 in urunler)
            {
                Console.WriteLine(urun2.Adi);
                Console.WriteLine(urun2.Fiyat);
                Console.WriteLine(urun2.Aciklama);
                Console.WriteLine(urun2.StokAdedi);
                Console.WriteLine("---------------");

            }

            Console.WriteLine("--------------METOTLAR--------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun);
            sepetManager.Ekle(urun1);

        }
    }
}
