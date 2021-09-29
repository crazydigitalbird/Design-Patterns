using System;

namespace ConcreteDecorator
{
    class ConcreteComponentB: Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponentB.Operation");
        }
    }
}
