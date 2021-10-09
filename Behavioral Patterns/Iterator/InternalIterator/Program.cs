using System;
using System.Collections;

namespace InternalIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable enumerable = new Enumerable();
            IEnumerable power2List = enumerable.Transform(Power2);
            foreach(var item in power2List)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 10));

            IEnumerable power3List = enumerable.Transform(x => Math.Pow(x, 3));
            foreach(var item in power3List)
            {
                Console.WriteLine(item);
            }
        }

        static double Power2(double arg)
        {
            return Math.Pow(arg, 2);
        }
    }
}
