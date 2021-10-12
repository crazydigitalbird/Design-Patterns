using System.Collections;

namespace Observer_Pull.Pattern
{
    abstract class Subject
    {
        private ArrayList observers = new ArrayList();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
