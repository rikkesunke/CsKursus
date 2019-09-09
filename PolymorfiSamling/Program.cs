using System;
using System.Collections.Generic;

namespace PolymorfiSamling
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund();
            Kat k = new Kat();

            h.Navn = "Vuffi";
            k.Navn = "Garfield";

            h.SigNoget();
            k.SigNoget();

            List<Dyr> forskelligeDyr = new List<Dyr>();

            forskelligeDyr.Add(k);
            forskelligeDyr.Add(h);
            forskelligeDyr.Add(new Hund() { Navn = "Streppe" });

            foreach (var item in forskelligeDyr)
            {
                item.SigNoget();
            }
        }
    }

    public abstract class Dyr
    {
        public string Navn { get; set; }

        public abstract void SigNoget();
    }

    public class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + this.Navn);
        }
    }

    public class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + this.Navn);
        }

    }
}
