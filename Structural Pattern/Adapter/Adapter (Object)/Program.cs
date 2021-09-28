namespace Adapter__Object_
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}
