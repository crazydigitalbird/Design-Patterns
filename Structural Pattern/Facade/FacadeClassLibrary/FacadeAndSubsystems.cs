using System;

namespace FacadeClassLibrary
{
    public class Facade
    {
        private SubSystemA subSystemA;
        private SubSystemB subSystemB;

        public Facade()
        {
            this.subSystemA = new SubSystemA();
            this.subSystemB = new SubSystemB();
        }
        public void Operation()
        {
            this.subSystemA.OperationA();
            this.subSystemB.OperationB();
        }
    }

    internal class SubSystemA
    {
        public void OperationA()
        {
            Console.WriteLine("SubSystemA.OperationA");
        }
    }


    internal class SubSystemB
    {
        public void OperationB()
        {
            Console.WriteLine("SubSystemA.OperationB");
        }
    }
}
