using System;

namespace _10tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi lave da lige en lille 10-tabel");

            for (int xx = 1; xx < 11; xx++)
            {
                for (int yy = 1; yy < 11; yy++)
                {
                    string tal = (xx * yy).ToString();
                    if ((xx * yy) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    // write laver ikke linje skift efter der er skrevet til output dvs at i dette tilfælde bliver tallene skrevet ud efter hinanden
                    // hvilket jo faktisk svarer til en konkatenering bare lavet meget mere simpelt


                    // padleft sætter blanke ind før det udregnede tal på venstre side således at tallene kommer til at stå over hinanden
                    Console.Write(tal.PadLeft(5));
                }
                // denne tomme writeline sørger for at der kommer en ny linje inden vi starter på næste runde i tabellen.
                Console.WriteLine();
                // denne nulstiller skrift farven inden en ny runde i møllen
                Console.ForegroundColor = ConsoleColor.Gray;

            }
        }
    }
}
