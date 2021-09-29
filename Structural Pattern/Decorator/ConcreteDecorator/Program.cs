using System;

namespace ConcreteDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponentA();
            ConcreteDecorator decorator = new ConcreteDecorator();
            decorator.Component = component;
            decorator.Operation();

            Console.WriteLine(new string('-', 20));

            component = new ConcreteComponentB();
            decorator.Component = component;
            decorator.Operation();
        }
    }
}
