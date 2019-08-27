using System.Collections.Generic;

namespace Indkapsling
{
    public class Konto
    {

        private List<Transaktion> transaktioner;

        public Konto()
        {
            transaktioner = new List<Transaktion>();
        }

        public void TilføjTransaktion(Transaktion t)
        {
            transaktioner.Add(t);
        }

        public decimal Saldo()
        {
            decimal sum = 0;
            foreach (var item in transaktioner)
            {
                sum += item.beløb;
            }
            return sum;
        }
    }
}
