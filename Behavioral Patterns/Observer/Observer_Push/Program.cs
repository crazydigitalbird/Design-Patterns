using Observer_Push.Pattern;

namespace Observer_Push
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
