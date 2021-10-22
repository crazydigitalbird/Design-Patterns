using System;

namespace Strategy
{
    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(nameof(ConcreteStrategyA));
        }
    }
}
