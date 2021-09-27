namespace Adapter__Class_
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }
}
