using System;

namespace BridgeCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction(7);
            Console.WriteLine(abstraction.Implementor.GetType());

            abstraction = new RefinedAbstraction(25);
            Console.WriteLine(abstraction.Implementor.GetType());
        }
    }
}
