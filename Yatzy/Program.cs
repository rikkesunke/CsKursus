using System;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Terning t1 = new Terning();
            //t1.udskriv();
            //t1.ryst();
            //t1.udskriv();

            //Console.WriteLine("snyde terning");
            //Terning t2 = new Terning(true);
            //t2.udskriv();
            //t2.ryst();
            //t2.udskriv();

            Console.WriteLine("brug af bæger");

            Bæger b1 = new Bæger();

            b1.skriv();
            b1.ryst();
            b1.skriv();
                       
        }
    }
}
