using System;

namespace State.Pattern
{
    class ConcreteStateA : State
    {
        public ConcreteStateA()
        {
            Console.WriteLine("ConcreteStateA");
        }

        public override void Handler(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
