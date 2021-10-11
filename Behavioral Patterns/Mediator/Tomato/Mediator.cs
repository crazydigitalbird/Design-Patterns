namespace Tomato
{
    abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
}
