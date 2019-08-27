using System;

namespace EgenskaberTrekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(10,10);

            Console.WriteLine($"Arealet er {t.Areal}");
        }
    }

    public class Trekant
    {
        public Trekant()
        {

        }

        public Trekant(int grundlinje, int højde)
        {
            this.Højde = højde;
            this.Grundlinje = grundlinje;
        }

        private int grundlinje;

        private int Grundlinje
        {
            get { return grundlinje; }
            set { grundlinje = value; }
        }

        private int højde;

        private int Højde
        {
            get { return højde; }
            set { højde = value; }
        }

        private double areal;

        public double Areal
        {
            get { return this.Grundlinje * this.Højde * 0.5; }
         
        }


    }
}
