using System;
using System.Collections;

namespace Composite
{
    class Composite: Component
    {
        private ArrayList nodes = new ArrayList();

        public Composite(string name): base(name){ }

        public override void Operation()
        {
            Console.WriteLine(name);

            foreach(Component c in nodes)
            {
                c.Operation();
            }
        }

        public override Component GetChild(int index)
        {
            return nodes[index] as Component;
        }

        public override void Add(Component component)
        {
            nodes.Add(component);
        }

        public override void Remode(Component component)
        {
            nodes.Remove(component);
        }
    }
}
