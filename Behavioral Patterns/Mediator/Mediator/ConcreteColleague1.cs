using System;

namespace Mediator
{
    class ConcreteColleague1: Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator) { }

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
