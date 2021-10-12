using Observer_Pull.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pull
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver(subject);
            ConcreteObserver observer2 = new ConcreteObserver(subject);
            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.State = "New state...";
            subject.Notify();

        }
    }
}
