using System;
using System.Collections.Generic;

namespace RecursionComposition
{
    class Composite : Component
    {
        private Dictionary<int, Component> nodes = new Dictionary<int, Component>();

        public Composite(string name) : base(name) { }

        public override void Operetion()
        {
            Console.WriteLine(name);

            foreach (var node in nodes)
            {
                node.Value.Operetion();
            }
        }

        public override void Add(int key, Component value)
        {
            nodes.Add(key, value);
        }

        private int position = -1;

        public override void Build(int[] rules)
        {
            if (position < rules.Length - 1)
            {
                int rule = rules[++position] % 2;

                if (!nodes.ContainsKey(rule))
                {
                    nodes.Add(rule, new Composite("branch " + rule.ToString()));
                }

                nodes[rule].Add(rules[position], new Leaf(position.ToString()));

                Build(rules);
            }
        }
    }
}
