using System.Collections;
using System.Collections.Generic;

namespace InternalIterator
{
    public delegate double Function(double arg);

    class Enumerable
    {
        List<double> list = new List<double> { 1, 2, 3, 4 };

        public IEnumerable Transform(Function function)
        {
            foreach(var item in list)
            {
                yield return function(item);
            }
        }
    }
}
