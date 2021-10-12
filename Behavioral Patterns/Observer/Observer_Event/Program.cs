using Observer_Event.Pattern;
using System;

namespace Observer_Event
{
    class Program
    {

        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            Observer observer1 = new Observer(state => Console.WriteLine($"{state} 1"));
            subject.Event += observer1;
            subject.Event += state => Console.WriteLine($"{state} 2");
            subject.State = "State";
            subject.Notify();

            Console.WriteLine(new string('-', 10));

            subject.Event -= observer1;
            subject.Notify();
        }
    }
}
