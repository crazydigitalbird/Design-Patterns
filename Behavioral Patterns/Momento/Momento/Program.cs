using Momento.Pattern;
using System;

namespace Momento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";

            Caretaker caretaker = new Caretaker();
            caretaker.Momento = originator.CreateMomento();

            originator.State = "Off";

            originator.SetMomento(caretaker.Momento);

            Console.WriteLine(originator.State);
        }
    }
}
