using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic oldugu için calişmasına izi veremez
            //bu yüzden ona ne ile çalişacağimizi soylemeliyiz.

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Hüseyin");

            MyList<string> names = new MyList<string>();


        }
    }
}
