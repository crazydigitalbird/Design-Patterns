namespace Mediator
{
    class ConcreteMediator: Mediator
    {
        public ConcreteColleague1 colleague1 { get; set; }
        public ConcreteColleague2 colleague2 { get; set; }

        public override void Send(string msg, Colleague colleague)
        {
            if(colleague == colleague1)
            {
                colleague2.Notifi(msg);
            }
            else
            {
                colleague1.Notifi(msg);
            }
        }
    }
}
