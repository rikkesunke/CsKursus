using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\tmp");
            w.EnableRaisingEvents = true;
            w.Created += (s, e) => Console.WriteLine("Fil oprettet");
            w.Deleted += (s, e) => Console.WriteLine("Fil slettet");
            do { } while (true);
        }
    }
}
