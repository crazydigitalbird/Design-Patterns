using System.Collections.Generic;

namespace PluggableAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITarget> targets = new List<ITarget>();
            targets.Add(new Target());
            targets.Add(new PluggableAdapter(Adaptee.A));
            targets.Add(new PluggableAdapter(Adaptee.B));

            foreach(ITarget target in targets)
            {
                target.Request();
            }
        }
    }
}
