using System.Collections.Generic;

namespace Observer_ChangeManager.Pattern
{
    class SimpleChangeManager : ChangeManager
    {
        private static SimpleChangeManager singlton = new SimpleChangeManager();

        public static SimpleChangeManager Singlton
        {
            get
            {
                return singlton;
            }
        }

        private SimpleChangeManager() { }


        public override void Register(Subject subject, Observer observer)
        {
            if (!mapping.ContainsKey(subject))
            {
                mapping.Add(subject, new List<Observer>());
            }
            mapping[subject].Add(observer);
        }

        public override void Unregister(Subject subject, Observer observer)
        {
            if (!mapping.ContainsKey(subject))
            {
                return;
            }
            mapping[subject].Remove(observer);
        }

        public override void Notify()
        {
            foreach (var item in mapping)
            {
                foreach (var observer in item.Value)
                {
                    observer.Update(item.Key);
                }
            }
        }
    }
}
