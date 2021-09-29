using System;

namespace ConcreteDecorator
{
    class ConcreteComponentA: Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponentA.Operation");
        }
    }
}
