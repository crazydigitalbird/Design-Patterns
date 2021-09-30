namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject proxy = new Proxy();
            proxy.Request();
        }
    }
}
