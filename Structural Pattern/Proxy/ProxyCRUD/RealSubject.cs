using System.Collections.Generic;

namespace ProxyCRUD
{
    class RealSubject : Subject
    {
        private Dictionary<string, string> dictionary;

        public RealSubject()
        {
            this.dictionary = new Dictionary<string, string>();
            this.dictionary.Add("TestKey", "TestValue");
        }

        public override void Create(string key, string value)
        {
            this.dictionary.Add(key, value);
        }

        public override string Read(string key)
        {
            return this.dictionary[key];
        }

        public override bool Update(string key, string value)
        {
            if (this.dictionary.ContainsKey(key))
            {
                this.dictionary[key] = value;
                return true;
            }
            return false;
        }

        public override bool Delete(string key)
        {
            return this.dictionary.Remove(key);
        }
    }
}
