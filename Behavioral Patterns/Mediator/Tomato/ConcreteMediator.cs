using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomato
{
    class ConcreteMediator: Mediator
    {
        public Farmer Farmer { get; set; }
        public Cannery Cannery { get; set; }
        public Shop Shop { get; set; }

        public override void Send(string msg, Colleague colleague)
        {
            if(colleague == Farmer)
            {
                Cannery.MakeKetchup(msg);
            }
            else if(colleague == Cannery)
            {
                Shop.Sell(msg);
            }
        }
    }
}
