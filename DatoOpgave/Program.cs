using System;

namespace DatoOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1;
            d1 = DateTime.Now;

            Console.WriteLine(d1);

            d1 = d1.AddDays(10);

            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);

            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);

            Console.WriteLine(d1);

            DateTime d2, d3;

            d2 = new DateTime(2019, 8, 12);
            d3 = new DateTime(2019, 8, 18);

            TimeSpan t1 = d3.Subtract(d2);

            Console.WriteLine(t1.Days);

            TimeSpan t2 = new TimeSpan(16, 0, 0);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(0, 30, 0);
            Console.WriteLine(t3);
            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine(t4);
            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);
        }
    }
}
