using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.ForNavn = "Rikke";
            p.EfterNavn = "Larsen";
            Console.WriteLine($"Personens Navn er {p.FuldtNavn()}");

            Elev e = new Elev();
            e.KlasseLokale = "Rum 8.2.15";
            e.ForNavn = "Rikke Sunke";
            e.EfterNavn = "Larsen";
            Console.WriteLine($"Elevens Navn er {e.FuldtNavn()}");
            Console.WriteLine($"Eleven er i lokale {e.KlasseLokale}");

            Instruktør i = new Instruktør();
            i.ForNavn = "Michell";
            i.EfterNavn = "Cronberg";
            i.NøgleId = 9;
            Console.WriteLine($"Instruktørens Navn er {i.FuldtNavn()}");
            Console.WriteLine($"Instruktørens nøgleid er {i.NøgleId}");
        }
    }
}
