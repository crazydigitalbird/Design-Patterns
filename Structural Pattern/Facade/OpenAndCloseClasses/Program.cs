using FacadeClassLibrary;

namespace OpenAndCloseClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.Operation();
        }
    }
}
