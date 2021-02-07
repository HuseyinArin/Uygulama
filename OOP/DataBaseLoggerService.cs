using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
