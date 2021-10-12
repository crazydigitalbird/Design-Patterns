using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObservable.Pattern;

namespace IObservable
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentSubject subject = new CurrentSubject();

            CurrentObserver observer1 = new CurrentObserver("1", subject);
            CurrentObserver observer2 = new CurrentObserver("2", subject);
            CurrentObserver observer3 = new CurrentObserver("3", subject);
            CurrentObserver observer4 = new CurrentObserver("4", subject);

            IDisposable unSubscriber1 = subject.Subscribe(observer1);
            IDisposable unSubscriber2 = subject.Subscribe(observer2);
            IDisposable unSubscriber3 = subject.Subscribe(observer3);
            IDisposable unSubscriber4 = subject.Subscribe(observer4);

            using (subject)
            {
                subject.State = null;
                subject.Notify();

                Console.WriteLine(new string('-', 70) + "1");

                using (unSubscriber1)
                {
                    subject.State = "State 1 ...";
                    subject.Notify(); 
                }

                Console.WriteLine(new string('-', 70) + "2");

                subject.State = "State 2 ...";
                subject.Notify();

                Console.WriteLine(new string('-', 70) + "3");

                observer2.OnCompleted();

                subject.State = "State 3 ...";
                subject.Notify();
            }

            Console.WriteLine(new string('-', 70) + "4");

            observer3.OnCompleted();
        }
    }
}
