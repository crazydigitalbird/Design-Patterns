using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer_ChangeManager.Pattern
{
    class DAGChangeManager : ChangeManager, IEqualityComparer<Tuple<Subject, Observer>>
    {
        private static DAGChangeManager singlton = new DAGChangeManager();

        public static DAGChangeManager Singlton
        {
            get
            {
                return singlton;
            }
        }
        private DAGChangeManager() { }

        public override void Register(Subject subject, Observer observer)
        {
            if(!mapping.ContainsKey(subject))
            {
                mapping.Add(subject, new List<Observer>());
            }
            mapping[subject].Add(observer);
        }

        public override void Unregister(Subject subject, Observer observer)
        {
            if(!mapping.ContainsKey(subject))
            {
                return;
            }
            mapping[subject].Remove(observer);
        }

        public override void Notify()
        {
            var tuples = mapping.SelectMany(kv => kv.Value.Select(observer => new Tuple<Subject, Observer>(kv.Key, observer))).Distinct(this);

            foreach(var tuple in tuples)
            {
                tuple.Item2.Update(tuple.Item1);
            }
        }

        public bool Equals(Tuple<Subject, Observer> x, Tuple<Subject, Observer> y)
        {
            return x.Item2.Equals(y.Item2);
        }

        public int GetHashCode(Tuple<Subject, Observer> obj)
        {
            return obj.Item2.GetHashCode();
        }
    }
}
