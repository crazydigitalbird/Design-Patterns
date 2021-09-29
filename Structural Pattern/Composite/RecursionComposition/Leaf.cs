using System;

namespace RecursionComposition
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Operetion()
        {
            Console.WriteLine(name);
        }

        public override void Add(int key, Component value)
        {
            throw new NotImplementedException();
        }

        public override void Build(int[] rules)
        {
            throw new NotImplementedException();
        }
    }
}
