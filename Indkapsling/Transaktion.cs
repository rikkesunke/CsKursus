using System;

namespace Indkapsling
{
    public class Transaktion
    {
        public DateTime dato;
        public string text;
        public decimal beløb;

        public Transaktion(DateTime dato, string text, decimal beløb)
        {
            this.dato = dato;
            this.text = text;
            this.beløb = beløb;
        }
    }
}
