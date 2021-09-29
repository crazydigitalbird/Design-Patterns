namespace RecursionComposition
{
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(int key, Component value);
        
        public abstract void Build(int[] rules);

        public abstract void Operetion();
    }
}
