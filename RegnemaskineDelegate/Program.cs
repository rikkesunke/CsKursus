using System;

namespace RegnemaskineDelegate
{
    class Program
    {
        // public delegate int BeregnDelegate(int a, int b);



        static void Main(string[] args)

        {

            // Enten

            //BeregnDelegate s = new BeregnDelegate(Plus);

            //int res = Beregner(1, 1, s);

            //Console.WriteLine(res);
            int res = 0;
            res = Beregner(1, 1, Plus);


            // eller

            //BeregnDelegate s1 = Minus;

            //int res2 = Beregner(1, 1, s1);

            //Console.WriteLine(res2);

            int res2 = 0;
            res2 = Beregner(1, 1, Minus);

            // eller

            //int res3 = Beregner(1, 1, Gange);

            //Console.WriteLine(res3);



            // Find tilfældig

            var f = FindTilfældigFunktion();

            int res4 = f(5, 5);

            // eller

            // int res4 = FindTilfældigFunktion()(5,5);

            Console.WriteLine(res4);



        }

        //public static int Beregner(int a, int b, BeregnDelegate funktion)
        public static int Beregner(int a, int b, Func<int, int, int> funktion)
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



        public static Func<int,int,int> FindTilfældigFunktion()

        {

            if (System.DateTime.Now.Millisecond <= 250)

                return Plus;

            if (System.DateTime.Now.Millisecond <= 500)

                return Minus;

            if (System.DateTime.Now.Millisecond <= 750)

                return Gange;



            return Divider;


        }
    
    }
}
