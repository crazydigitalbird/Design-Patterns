using System;

namespace Decorator
{
    class ConcreteDecoratorB: Decorator
    {
        private void AddedBehavior()
        {
            Console.WriteLine("Added Behavior");
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}
