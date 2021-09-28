using System.Collections;
using System.Collections.Specialized;

namespace BridgeCollections
{
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(int size)
        {
            if(size < 10)
            {
                Implementor = new ListDictionary();
            }
            else
            {
                Implementor = new Hashtable();
            }
        }
    }
}
