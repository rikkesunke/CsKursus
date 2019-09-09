using System;

namespace AbstraktKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Kursist k = new Kursist() { Id = 1, Navn = "a" };
            k.Skriv1();
            k.Skriv2();
        }
    }

    public abstract class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public void Skriv1()
        {
            Console.WriteLine("Person med id " + this.Id + " og navn " + this.Navn);
        }

        public abstract void Skriv2();
        
    }

    public class Kursist : Person
    {
        override public void Skriv2()
        {
            Console.WriteLine("Person med id " + this.Id + " og navn " + this.Navn);
        }
    }
}
