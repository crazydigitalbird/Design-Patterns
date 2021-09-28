using System.Linq;
using System.Collections;

namespace BridgeCollections
{
    abstract class Abstraction
    {
        public IDictionary Implementor { get; protected set; }

        public object this[object key]
        {
            get { return Implementor[key]; }
        }

        public int Count
        {
            get { return Implementor.Count; }
        }
    }
}
