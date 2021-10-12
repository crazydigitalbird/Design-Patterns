using System.Collections;

namespace Observer_Push.Pattern
{
    abstract class Subject
    {
        ArrayList observers = new ArrayList();

        public abstract string State { get; set; }

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
                observer.Update(this.State);
            }
        }
    }
}
