namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementatorB());
            //Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementatorA());

            abstraction.Operation();
        }
    }
}
