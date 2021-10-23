using System;

namespace FlagDrow
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoColorFlag flag = new UkraineFlag();
            flag.Draw();

            Console.WriteLine();

            flag = new PolandFlag();
            flag.Draw();

            Console.WriteLine();
        }
    }
}
