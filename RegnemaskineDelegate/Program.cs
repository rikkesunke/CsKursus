using System;

namespace RegnemaskineDelegate
{
    class Program
    {
        public delegate int BeregnDelegate (int a, int b);

        static void Main(string[] args)
        {
            BeregnDelegate b1 = new BeregnDelegate(Plus);
            int res = Beregner(1, 1, b1);
            Console.WriteLine(res);

            // man kan også gøre sådan
            BeregnDelegate b2 = Minus;
            int res2 = Beregner(1, 1, b2);
            Console.WriteLine(res2);

            // eller

            int res3 = Beregner(1, 1, Gange);
            Console.WriteLine(res3);
        }

        public static int Beregner(int a, int b, BeregnDelegate funktion)
        {
            return funktion(a, b);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
