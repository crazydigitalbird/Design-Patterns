using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate aggregate = new CurrentAggregate();

            aggregate[0] = "Element A";
            aggregate[1] = "Element B";
            aggregate[2] = "Element C";
            aggregate[3] = "Element D";

            Iterator iterator = aggregate.CreateIterator();

            for(object o = iterator.First(); !iterator.isDone(); o = iterator.Next())
            {
                Console.WriteLine(o);
            }
        }
    }
}
