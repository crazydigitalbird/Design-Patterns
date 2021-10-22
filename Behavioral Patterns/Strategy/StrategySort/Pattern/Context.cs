using System;

namespace StrategySort
{
    class Context
    {
        private Strategy strategy;

        private int[] array = { 3, 5, 1 ,2 , 4 };

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void Sort()
        {
            strategy.Sort(array);
        }

        public void PrintArray()
        {
            foreach(int a in array)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }
    }
}
