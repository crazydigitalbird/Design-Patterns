using System;

namespace PluggableAdapter
{
    class Target : ITarget
    {
        public void Request()
        {
            Console.WriteLine("Target.Request");
        }
    }
}
