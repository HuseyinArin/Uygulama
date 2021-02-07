using OOP4;
using System;

class FileLoggerService : ILoggerService
{
    public void Log()
    {
        Console.WriteLine("Veritabanına loglandı");
    }
}
