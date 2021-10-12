namespace Observer_ChangeManager.Pattern
{
    class Subject
    {
        public string Name { get; set; }

        private ChangeManager manager;

        public Subject(string name, ChangeManager manager)
        {
            this.Name = name;
            this.manager = manager;
        }

        public void Attach(Observer observer)
        {
            manager.Register(this, observer);
        }

        public void Detach(Observer observer)
        {
            manager.Unregister(this, observer);
        }

        public void Notify()
        {
            manager.Notify();
        }
    }
}
