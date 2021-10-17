using System;

namespace State.Pattern
{
    class ConcreteStateB : State
    {
        public ConcreteStateB()
        {
            Console.WriteLine("ConcreteStateB");
        }

        public override void Handler(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
