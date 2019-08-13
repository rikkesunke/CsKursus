using System;

namespace Regnemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            double res;

            Console.WriteLine("Velkommen til regnemaskinen - vi kan + , - , * og / ");
            Console.WriteLine("Indtast første tal - tryk ENTER");

            string tal1s = Console.ReadLine();

            Console.WriteLine("Indtast regnetegn - tryk ENTER");

            string tegn = Console.ReadLine();

            Console.WriteLine("Indtast andet tal - tryk ENTER");

            string tal2s = Console.ReadLine();

            double t1 = Convert.ToDouble(tal1s);
            double t2 = Convert.ToDouble(tal2s);

            switch (tegn)
            {
                case "+":
                    Console.WriteLine($"TADA!!! og res er = ");
                    res = t1 + t2;
                    Console.WriteLine(res.ToString("N2"));
                    break;
                case "-":
                    Console.WriteLine($"TADA!!! og res er = ");
                    res = t1 - t2;
                    Console.WriteLine(res.ToString("N2"));
                    break;
                case "*":
                    Console.WriteLine($"TADA!!! og res er = ");
                    res = t1 * t2;
                    Console.WriteLine(res.ToString("N2"));
                    break;
                case "/":
                    if (t1 == 0)
                    {
                        Console.WriteLine("Division med 0 det kan vi ikke");
                    }
                    else
                    {
                        Console.WriteLine($"TADA!!! og res er = ");
                        res = t1 / t2;
                        Console.WriteLine(res.ToString("N2"));
                    }
                    break;
            }


        }
    }
}
