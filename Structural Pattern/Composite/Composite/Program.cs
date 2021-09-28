﻿namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("root");
            Component branch1 = new Composite("BR1");
            Component branch2 = new Composite("BR2");
            Component leaf1 = new Leaf("leaf1");
            Component leaf2 = new Leaf("leaf2");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch2.Add(leaf2);

            root.Operation();
        }
    }
}
