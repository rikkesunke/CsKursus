using System;

namespace Egenskaber3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.ForNavn = "Rikke";
            p.EfterNavn = "Larsen";
            Console.WriteLine($"Personens fulde navn er: {p.FuldtNavn()}");
        }
    }

    class Person
    {
        public string ForNavn { get; set; }

        private string _efternavn;

        public string EfterNavn
        {
            get { return _efternavn; }
            set { if (value.Length < 3)
                    _efternavn = "";
                  else
                    _efternavn = value; }
        }

        public string FuldtNavn()
        {
            return this.ForNavn + " " + this.EfterNavn;
        }
    }
}
