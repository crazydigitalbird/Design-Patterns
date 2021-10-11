using Backpack.Pattern;
using System;

namespace Backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            Man Johan = new Man();
            Robot ASIMO = new Robot();

            Johan.Things = "T-shirt, jeans, sneakers";

            ASIMO.Backpack = Johan.Undress();

            Johan.Things = "Swimming Trunks";

            Johan.Dress(ASIMO.Backpack);

            Console.WriteLine(Johan.Things);
        }
    }
}
