namespace Arv
{
    class Person
    {
        public string ForNavn { get; set; }
        public string EfterNavn { get; set; }

        public string FuldtNavn()
        {
            return this.ForNavn + " " + this.EfterNavn;
        }
    }
}
