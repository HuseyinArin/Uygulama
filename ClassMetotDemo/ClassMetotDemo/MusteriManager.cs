using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi +  " : Kullanıcı adlı hesaba para yatırıldı..");
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + ": Kullanıcı adlı hesapta güncelleme yapıldı..");

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + ": kullanıcı adlı hesaptaki para silindi..");

        }

    }
}
