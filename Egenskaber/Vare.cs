namespace Egenskaber
{
    class Vare
    {
        //default constructor
        public Vare()
        { }

        // custom constructor
        public Vare(string navn, double pris)
        {
            this.Pris = pris;
            this.VareNavn = navn;
        }
        private double pris;

        public double Pris
        {
            get { return pris; }
            set { pris = value; }
        }

        private string vareNavn;

        public string VareNavn
        {
            get { return vareNavn; }
            set { vareNavn = value; }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }



    }
}
