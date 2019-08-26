using System;
using System.Collections.Generic;

namespace Samlinger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();

            lst.Add(4);
            lst.Add(6);
            lst.Add(9);

            foreach (int item in lst)
            {
                Console.WriteLine($"elementer i liste: "+ item );
            }

            Dictionary<int, string> navn = new Dictionary<int, string>();

            navn.Add(1, "Rikke");
            navn.Add(2, "Bent");
            navn.Add(3, "Lene");

            string p = navn[3];

            Console.WriteLine(p);

        }
    }
}
