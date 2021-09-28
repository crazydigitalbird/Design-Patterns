using System;

namespace Builder
{
    class ConcreteImplementatorB : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("ConcreteImplementatorB.OperationImp");
        }
    }
}
