using System;

namespace Observer_ChangeManager.Pattern
{
    class Observer
    {
        public string Name { get; set; }

        public Observer(string name)
        {
            this.Name = name;
        }

        public void Update(Subject subject)
        {
            Console.WriteLine($"{subject.Name} -> {this.Name}");
        }
    }
}
