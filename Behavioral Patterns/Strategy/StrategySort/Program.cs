using System;
using System.Diagnostics;

namespace StrategySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy strategy = new BubbleSort();
            Context context = new Context(strategy);
            context.Sort();
            context.PrintArray();
            Console.WriteLine(new string('-', 20));

            strategy = new SelectionSort();
            context = new Context(strategy);
            context.Sort();
            context.PrintArray();

            Console.WriteLine(new string('-', 20));

            strategy = new InsertSort();
            context = new Context(strategy);
            context.Sort();
            context.PrintArray();
        }
    }
}
