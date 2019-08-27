using System;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            // brug af default constructor uden variabler

            Vare v = new Vare();
            v.VareNavn = "Vare #1";
            double beregnetPris = 0;
            v.Pris = 100;

            beregnetPris = v.PrisMedMoms();

            Console.WriteLine($"Prisen med moms for {v.VareNavn} = {beregnetPris} kr");

            // brug af custom constructor

            Vare v2 = new Vare("Vare #2",200);
            Console.WriteLine($"Prisen med moms for {v2.VareNavn} = {v2.PrisMedMoms()} kr");

        }
    }
}
