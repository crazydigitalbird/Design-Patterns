using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable bank = new Bank();
            IEnumerator cashier = bank.GetEnumerator();

            while(cashier.MoveNext())
            {
                Console.WriteLine((cashier.Current as Banknote).Nominal);
            }
        }
    }
}
