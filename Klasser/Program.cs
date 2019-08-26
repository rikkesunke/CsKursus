using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Efternavn = "Larsen";
            p1.Fornavn = "Rikke";
            p1.Fødselsår = 1975;

            Console.WriteLine(p1.fuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());

            Person p2 = new Person("Rikke Sunke", "Larsen", 1975);
            Console.WriteLine(p2.fuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());

        }
    }
}
