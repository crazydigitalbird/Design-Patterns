namespace Composite
{
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }
       
        public abstract void Operation();

        public abstract Component GetChild(int index);

        public abstract void Add(Component component);

        public abstract void Remode(Component component);
    }
}
