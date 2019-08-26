using System;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Terning t1 = new Terning();
            t1.udskriv();
            t1.ryst();
            t1.udskriv();

            Console.WriteLine("snyde terning");
            Terning t2 = new Terning(true);
            t2.udskriv();
            t2.ryst();
            t2.udskriv();

            Console.WriteLine("brug af bæger");

            Bæger b1 = new Bæger();

            b1.skriv();
            b1.ryst();
            b1.skriv();
                       
        }
    }
    class Bæger
    {
        private Terning[] terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
                ryst();
            }
        }

        public void ryst()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i].ryst();
            }
        }

        public void skriv()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i].udskriv();
                Console.WriteLine();
            }
        }
    }

}
