using System;

namespace Klasser
{
    class Person
    {

        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string fuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }
        // default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        // custom constructor
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }
    }
}
