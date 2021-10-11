using System;

namespace Tomato
{
    class Farmer: Colleague
    {
        public Farmer(Mediator mediator): base(mediator) { }

        public void GrowTomato()
        {
            string tomato = "tomato";
            Console.WriteLine($"{this.GetType().Name} raised {tomato}");
            mediator.Send(tomato, this);
        }
    }
}
