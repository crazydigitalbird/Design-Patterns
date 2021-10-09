using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();

            foreach(var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 10)); ;

            int[] array = new int[20];
            collection.CopyTo(array, 2);

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
