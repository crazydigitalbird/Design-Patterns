using System;

namespace Composite
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Operation()
        {
            Console.WriteLine(name);
        }

        public override Component GetChild(int index)
        {
            throw new NotImplementedException();
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remode(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
