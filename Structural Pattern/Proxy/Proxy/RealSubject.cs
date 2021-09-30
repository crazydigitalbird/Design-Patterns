using System;

namespace Proxy
{
    class RealSubject: Subject
    {
        public override void Request()
        {
            Console.WriteLine("Real Subject");
        }
    }
}
