namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);
            mediator.colleague1 = colleague1;
            mediator.colleague2 = colleague2;

            colleague1.Send("Message 1");
            colleague2.Send("Message 2");
        }
    }
}
