using System;

namespace IObservable.Pattern
{
    class CurrentObserver : IObserver<string>
    {
        private string name;
        private string observerState;
        private IDisposable unSubscriber;

        public CurrentObserver(string name, IObservable<string> subject)
        {
            this.name = name;
            this.unSubscriber = subject.Subscribe(this);
        }

        public void OnCompleted()
        {
            unSubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Observer {this.name}. Error: {error.Message}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void OnNext(string value)
        {
            this.observerState = value;
            Console.WriteLine($"Observer {this.name}. State = {this.observerState}");
        }
    }
}
