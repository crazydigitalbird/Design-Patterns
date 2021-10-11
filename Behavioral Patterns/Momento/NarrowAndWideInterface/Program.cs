using NarrowAndWideInterface.Pattern;
using System;

namespace NarrowAndWideInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker();

            originator.State = "On";

            caretaker.Momento = originator.GetMomento();

            originator.State = "Off";

            originator.SetMomento(caretaker.Momento as IWideInterface);

            Console.WriteLine(originator.State);
        }
    }
}
