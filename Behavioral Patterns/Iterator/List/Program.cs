using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List() { 1, 2, 3, 4, 5};

            list.Add(6);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
