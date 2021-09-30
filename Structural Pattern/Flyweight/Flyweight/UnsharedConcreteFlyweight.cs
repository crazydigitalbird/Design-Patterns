﻿using System;

namespace Flyweight
{
    class UnsharedConcreteFlyweight: Flyweight
    {
        private string allState = "UnsharedConcreteFlyweight";
        public override void Operation(ConsoleColor extrinsicState)
        {
            Console.ForegroundColor = extrinsicState;
            Console.WriteLine(allState + GetHashCode());
        }
    }
}
