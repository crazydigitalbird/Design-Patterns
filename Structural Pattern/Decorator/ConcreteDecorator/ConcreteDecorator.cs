using System;

namespace ConcreteDecorator
{
    class ConcreteDecorator: Component
    {
        public Component Component { protected get; set; }

        public override void Operation()
        {
            if(Component != null)
            {
                Component.Operation();
            }
            AddedBehavior();
        }

        private void AddedBehavior()
        {
            Console.WriteLine("Added Behavior");
        }
    }
}
