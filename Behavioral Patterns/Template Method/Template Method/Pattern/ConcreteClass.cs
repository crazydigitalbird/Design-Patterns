using System;

namespace Template_Method
{
    class ConcreteClass : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine(nameof(PrimitiveOperation1));
        }

        protected override void PrimiteveOperation2()
        {
            Console.WriteLine(nameof(PrimiteveOperation2));
        }
    }
}
