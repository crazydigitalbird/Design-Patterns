using Observer_ChangeManager.Pattern;

namespace Observer_ChangeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeManager manager = SimpleChangeManager.Singlton;
            manager = DAGChangeManager.Singlton;

            Subject subject1 = new Subject("Subject 1", manager);
            Subject subject2 = new Subject("Subject 2", manager);

            Observer commonObserver = new Observer("Common Observer");

            subject1.Attach(commonObserver);
            subject1.Attach(new Observer("Observer 1"));
            subject1.Attach(new Observer("Observer 2"));

            subject2.Attach(commonObserver);
            subject2.Attach(new Observer("Observer 3"));

            subject1.Notify();

        }
    }
}
