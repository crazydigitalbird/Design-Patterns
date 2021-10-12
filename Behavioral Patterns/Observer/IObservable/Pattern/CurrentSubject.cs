using System;
using System.Collections.Generic;

namespace IObservable.Pattern
{
    class CurrentSubject : IObservable<string>, IDisposable
    {
        public string State { get; set; }

        List<IObserver<string>> observers = new List<IObserver<string>>();

        public void Notify()
        {
            foreach(var observer in observers)
            {
                if(this.State == null)
                {
                    observer.OnError(new NullReferenceException());
                }
                else
                {
                    observer.OnNext(this.State);
                }
            }
        }


        public IDisposable Subscribe(IObserver<string> observer)
        {
            if(!observers.Contains(observer))
            {
                observers.Add(observer);
            }

            return new UnSubscribe(observers, observer);
        }

        public void Dispose()
        {
            observers.Clear();
        }

        class UnSubscribe : IDisposable
        {
            private List<IObserver<string>> observers;

            private IObserver<string> observer;

            public UnSubscribe(List<IObserver<string>> observers, IObserver<string> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observers.Contains(observer))
                {
                    observers.Remove(observer);
                }
                else
                {
                    observer.OnError(new Exception("Данный подписчик не подписан на издателя."));
                }
            }
        }
    }
}
