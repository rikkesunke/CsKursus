using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumLøn = 0;
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };

            for (int i = 0; i < månedsløn.Length; i++)
            {
                sumLøn += månedsløn[i];
                Console.WriteLine(månedsløn[i]);
            }

            double snit = sumLøn / månedsløn.Length;
            Console.WriteLine("Den gns månedsløn er: " + snit.ToString("N2"));

            string txt = "3;5;22;1;10;15;5";
            string[] data = txt.Split(';');
            Console.WriteLine(string.Join(" ",data));
            Console.WriteLine(string.Join("",data));

            int[] tal = { 5, 1, 3, 1, 6, 7, 1, 6, 8 };
            foreach (int t in tal)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine($"array før første kald: {String.Join(' ',tal)}");
            Console.WriteLine($"Mindste værdi: {FindMindsteVærdi_fejl(tal)}");
            Console.WriteLine($"array efter første kald: {String.Join(' ', tal)}");

            int[] tal1 = { 5, 1, 3, 1, 6, 7, 1, 6, 8 };

            Console.WriteLine($"array før første kald: {String.Join(' ', tal1)}");
            Console.WriteLine($"Mindste værdi: {FindMindsteVærdi(tal1)}");
            Console.WriteLine($"array efter første kald: {String.Join(' ', tal1)}");


            int FindMindsteVærdi_fejl(int[] array)
            {
                Array.Sort(array);
                return (array[0]);
            }

            int FindMindsteVærdi(int[] array)
            {
                int[] kopi = array.Clone() as int[];

                Array.Sort(kopi);
                return (kopi[0]);
            }


        }

    }
}
