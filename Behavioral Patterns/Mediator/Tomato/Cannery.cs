using System;

namespace Tomato
{
    class Cannery: Colleague
    {
        public Cannery(Mediator mediator): base(mediator) { }

        public void MakeKetchup(string msg)
        {
            string ketchup = $"{msg} ketchup";
            Console.WriteLine($"{this.GetType().Name} produced {ketchup}");
            mediator.Send(ketchup, this);
        }
    }
}
