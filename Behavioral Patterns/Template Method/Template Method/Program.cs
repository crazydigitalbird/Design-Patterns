namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            instance.TemplateMethod();
        }
    }
}
