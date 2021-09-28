using System;

namespace PluggableAdapter
{
    class PluggableAdapter : ITarget
    {
        private Action request;

        public PluggableAdapter(Adaptee adaptee)
        {
            switch (adaptee)
            {
                case Adaptee.A:
                    AdapteeA adapteeA = new AdapteeA();
                    request = adapteeA.SpecificRequestA;
                    break;

                case Adaptee.B:
                    AdapteeB adapteeB = new AdapteeB();
                    request = adapteeB.SpecificRequestB;
                    break;
            }
        }

        public void Request()
        {
            request.Invoke();
        }
    }
}
