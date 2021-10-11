using System;

namespace Mediator
{
    class ConcreteColleague2: Colleague
    {
        public ConcreteColleague2(Mediator mediator): base(mediator) { }

        public void Send(string msg)
        {
            mediator.Send(msg, this);
        }

        public void Notifi(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
