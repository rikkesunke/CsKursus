using System;

namespace Yatzy
{
    class Terning
    {
        public int værdi;
        private bool snyd;
        private static System.Random rnd = new System.Random();

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        public Terning(bool snyd)
        {
            this.snyd = true;
            ryst();
        }

        public void udskriv()
        {
            Console.WriteLine($"[" + this.værdi + "]");
        }

        public void ryst()
        {
            if (snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);
        }
    }
}
