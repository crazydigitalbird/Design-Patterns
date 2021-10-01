using System;

namespace ProxyCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject realSubject = new RealSubject();
            Subject proxy;

            Console.WriteLine($"{Role.Owner} work:");
            proxy = new Proxy(realSubject, Role.Owner);
            TryAccess(proxy, "Jone");

            Console.WriteLine($"{Role.Administrator} work:");
            proxy = new Proxy(realSubject, Role.Administrator);
            TryAccess(proxy, "Mike");

            Console.WriteLine($"{Role.Manager} work:");
            proxy = new Proxy(realSubject, Role.Manager);
            TryAccess(proxy, "Kate");

            Console.WriteLine($"{Role.User} work:");
            proxy = new Proxy(realSubject, Role.User);
            TryAccess(proxy, "Poul");
        }

        private static void TryAccess(Subject proxy, string name)
        {            
            try
            {
                proxy.Create(name, "TestValue");
                Console.WriteLine("Create - OK!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                proxy.Read("TestKey");
                Console.WriteLine("Read - OK!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                proxy.Update(name, "NewTestValue");
                Console.WriteLine("Update - OK!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                proxy.Delete(name);
                Console.WriteLine("Delete - OK!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(new string('-', 50));
        }

    }
}
