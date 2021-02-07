using System;
using System.Collections.Generic;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManger konutKrediManger = new KonutKrediManger();
            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            basvuruManager.BasvuruYap(ıhtiyacKrediManager,databaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { konutKrediManger };
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }

    }
}
