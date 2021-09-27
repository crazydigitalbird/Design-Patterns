namespace Adapter__Class_
{
    class Adapter: Adaptee, ITarget
    {
        public void Request()
        {
            base.SpecificRequest();
        }
    }
}
