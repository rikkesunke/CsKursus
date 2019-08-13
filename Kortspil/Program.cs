using System;

namespace Kortspil
{
    class Program
    {
        static void Main(string[] args)
        {
           // int kortVærdi = 2;
            Kulør Kortkulør = Kulør.hjerter;
            farve kortFarve = farve.rød;


            Console.WriteLine($"Jeg har valgt kortKulør: {Kortkulør.ToString()}");
            Console.WriteLine($"Den har værdien        : {(int)Kortkulør}");

            Console.WriteLine($"Kortfarven er          : {kortFarve.ToString()}");
            Console.WriteLine($"Den har værdien        : {(int)Kortkulør}");

        }
    }
}
