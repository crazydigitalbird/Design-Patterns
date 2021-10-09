using System;
using System.Collections;

namespace InternalIterator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable enumerable = new Enumerable();

            IEnumerable pow2List = enumerable.Transform(x => Math.Pow(x, 2));
            foreach(var item in pow2List)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 10));

            IEnumerable pow3List = enumerable.Transform(x => Math.Pow(x, 3));
            foreach(var item in pow3List)
            {
                Console.WriteLine(item);
            }
        }
    }
}
