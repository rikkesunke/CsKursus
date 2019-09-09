using System;

namespace InterfaceOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] funkAr = new IDbFunktioner[4];

            funkAr[0] = new Hund();
            funkAr[1] = new Ubåd();
            funkAr[2] = new Hund();
            funkAr[3] = new Ubåd();

            foreach (var item in funkAr)
            {
                item.Gem();
            }
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }
    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("Vi gemmer hund");
        }
    }

    class Ubåd : IDbFunktioner
    {
       
        public int Nummer { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Vi gemmer ubåd");
        }

    }
}
