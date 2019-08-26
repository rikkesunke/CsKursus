using System;

namespace MetoderIO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool findes = System.IO.File.Exists(@"c:\temp\test.txt");
            Console.WriteLine($"Findes filen: {findes}");

            string indhold = System.IO.File.ReadAllText(@"c:\temp\test.txt");
            Console.WriteLine(indhold);

            var fil = new System.IO.FileInfo(@"c:\temp\test.txt");
            DateTime sidstLæst = fil.LastAccessTime;
            Console.WriteLine($"Filen er sidst læst: {sidstLæst}");

            string extension = fil.Extension;
            Console.WriteLine($"Filens extension er: {extension}");
        }
    }
}
