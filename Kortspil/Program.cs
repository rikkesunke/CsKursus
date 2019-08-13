using System;

namespace Kortspil
{
    class Program
    {
        static void Main(string[] args)
        {
           // int kortVærdi = 2;
            Kulør Kortkulør = Kulør.hjerter;

            Console.WriteLine(Kortkulør.ToString());
            Console.WriteLine((int)Kortkulør);

        }
    }
}
