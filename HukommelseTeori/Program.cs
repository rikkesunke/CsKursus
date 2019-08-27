using System;

namespace HukommelseTeori
{
    class Program
    {
        static void Main(string[] args)
        {
            Person k1 = new Person() { Id = 1 };
            Person k2 = new Person();
            k2.Id = 2;
            // STRUCT PERSON skriver den k1 = 1 og k2 = 2 - det er to forskellige instanser der er initialiseret til forskellige værdier - de ligger i stack
            // CLASS PERSON skriver den k1 = 1 og k2 = 2 - det er to forskellige referance værdier - de ligger i heap
            Console.WriteLine($"k1: {k1.Id}");
            Console.WriteLine($"k2: {k2.Id}");

            k1 = k2;
            // STRUCT PERSON nu skriver den 2 for begge variabler fordi de sættes lig med hinanden - de ligger i stack
            // CLASS PERSON nu skriver den 2 for begge variabler fordi de sættes lig med hinanden og de dermed peger på samme referance værdi - de ligger i heap
            Console.WriteLine($"k1: {k1.Id}");
            Console.WriteLine($"k2: {k2.Id}");
            
            k1.Id = 3;
            // STRUCT PERSON nu skriver den k1 = 3 og k2 = 2 da k1 nu er initialiseret til en ny værdi - de ligger i stack
            // CLASS PERSON nu skriver den k1 = 3 og k2 = 3 da de begge peger på samme referance i heapen - de ligger i heap
            Console.WriteLine($"k1: {k1.Id}");
            Console.WriteLine($"k2: {k2.Id}");

        }
    }

    class Person
    {
        public int Id;
    }
}
