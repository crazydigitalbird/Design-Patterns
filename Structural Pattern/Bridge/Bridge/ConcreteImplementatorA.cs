using System;

namespace Builder
{
    class ConcreteImplementatorA : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementatorA.OperationImp");
        }
    }
}
