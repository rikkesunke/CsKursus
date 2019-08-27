using System;

namespace Yatzy
{
    public class Bæger
    {
        private Terning[] terninger = new Terning[5];
        //default constructor - afvikles automatisk når der lavet en new instans af klassen - har ingen retur værdi og ingen argumenter
        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }
            ryst();
        }

        public void ryst()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i].ryst();
            }
        }

        public void skriv()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i].udskriv();
            }
            Console.WriteLine();
        }
    }

}
