namespace Adapter__Object_
{
    class Adapter: Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
