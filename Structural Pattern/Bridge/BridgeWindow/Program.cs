namespace BridgeWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new MacWindow();
            //Window window = new MSWindow();
            window.Draw();            
        }
    }
}
