using System;

namespace Arv2
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom u = new UdvidetRandom();
            Console.WriteLine(u.NextBool());
        }
    }

    class UdvidetRandom : Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1002) < 501; 
        }
    }
}
