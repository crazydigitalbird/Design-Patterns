using System;

namespace Observer_Delegate
{
    class Program
    {
        //Издатель
        delegate void SubjectObserver();

        //Update - логически относится к подписчику (Observer)
        static void Update()
        {
            Console.WriteLine("Hellow world");
        }

        static void Main(string[] args)
        {
            SubjectObserver subject = new SubjectObserver(Update);

            //Аналог вызова Notify() - логически относится к издателю (Subject)
            subject.Invoke();
        }
    }
}
