using System;

namespace VariabelString
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Rikke";
            string efternavn = "Larsen";

            Console.WriteLine($"Fulde navn: {fornavn} {efternavn}");

            string navn = fornavn + " " + efternavn;

            Console.WriteLine($"Navn i upper case: {navn.ToUpper()}");

            Console.WriteLine($"Navn i lower case: {navn.ToLower()}");

            // substring tæller fra 0 ikke fra 1 som i fx PL1 - hvis en streng er 10 karakterer så vil en tæller på strengen returnere 10

            Console.WriteLine($"Navn i upper case: {navn.Substring(6,3)}");

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);

            System.IO.File.WriteAllText("c:\\temp\\test.txt", navn);

            string b = "b", c = "d";
            int res = string.Compare(b, c);
            Console.WriteLine($"sammenlign b med c = {res}");
            res = string.Compare(c, b);
            Console.WriteLine($"sammenlign c med b = {res}");
            res = string.Compare(c, c);
            Console.WriteLine($"sammenlign c med c = {res}");

        }
    }
}
