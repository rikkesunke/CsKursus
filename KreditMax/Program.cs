using System;

namespace KreditMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => { Console.WriteLine("Kredit overskredet. KreditMax er: " + k.KreditMax); };

            k.Saldo = 500;
            Console.WriteLine("Saldoen er: " + k.Saldo);
            k.Køb(100);
            Console.WriteLine("Saldoen er: " + k.Saldo);
            k.Køb(600);
            Console.WriteLine("Saldoen er: " + k.Saldo);
            k.Køb(200);
            Console.WriteLine("Saldoen er: " + k.Saldo);
            k.Køb(800);
            Console.WriteLine("Saldoen er: " + k.Saldo);
        }
    }

    public class Kunde
    {
        public event EventHandler KreditOverskredet;
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}",Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
                KreditOverskredet?.Invoke(this, new EventArgs());
        }
    }
}
