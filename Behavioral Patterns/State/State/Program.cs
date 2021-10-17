using State.Pattern;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context contex = new Context(new ConcreteStateA());
            contex.Request();
            contex.Request();
        }
    }
}
