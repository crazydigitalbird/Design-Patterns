using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flyweight[] flyweight = new Flyweight[100];
            FlyweightFactory factory = new FlyweightFactory();

            for(int i = 0; i < flyweight.Length; i++)
            {
                flyweight[i] = factory.GetConcreteFlyweight("1");
                flyweight[i].Operation(ConsoleColor.Red);
            }

            for(int i = 0; i < flyweight.Length; i++)
            {
                flyweight[i] = factory.GetUnsharedConcreteFlyweight();
                flyweight[i].Operation(ConsoleColor.Green);
            }
        }
    }
}
