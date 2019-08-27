using System;

namespace Indkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k = new Konto();
            k.TilføjTransaktion(new Transaktion(new DateTime(2019, 1, 1), "Indsat", 100));
            k.TilføjTransaktion(new Transaktion(new DateTime(2019, 2, 1), "Indsat", 100));
            k.TilføjTransaktion(new Transaktion(new DateTime(2019, 3, 1), "Hævet", -75));
            Console.WriteLine($"Din saldo er: {k.Saldo()}");
        }
    }
}
