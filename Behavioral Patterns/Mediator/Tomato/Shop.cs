using System;

namespace Tomato
{
    class Shop: Colleague
    {
        public Shop(Mediator mediator): base(mediator) { }

        public void Sell(string msg)
        {            
            Console.WriteLine($"{this.GetType().Name} sold {msg}");
        }
    }
}
