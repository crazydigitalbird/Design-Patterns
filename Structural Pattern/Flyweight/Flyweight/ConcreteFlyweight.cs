using System;

namespace Flyweight
{
    class ConcreteFlyweight: Flyweight
    {
        private string intrinsicsStata = "ConcteteFlyweight";
        private ConsoleColor extrinsicState;
        public override void Operation(ConsoleColor extrinsicState)
        {
            this.extrinsicState = extrinsicState;
            Console.ForegroundColor = this.extrinsicState;
            Console.WriteLine(intrinsicsStata + GetHashCode());
        }
    }
}
