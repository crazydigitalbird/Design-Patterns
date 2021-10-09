using System.Collections;
using System.Collections.Generic;

namespace InternalIterator2
{
    public delegate double Function(double arg);

    class Enumerable
    {
        private List<double> list = new List<double> { 1, 2, 3, 4, };

        public IEnumerable Transform(Function func)
        {
            return new Enumerator(this, func);
        }

        class Enumerator : IEnumerable, IEnumerator
        {
            private Enumerable enumerable;
            private Function function;

            private object current;
            private int position = 0;

            public Enumerator(Enumerable enumerable, Function function)
            {
                this.enumerable = enumerable;
                this.function = function;
            }

            public bool MoveNext()
            {
                if(position < enumerable.list.Count)
                {
                    current = function(enumerable.list[position]);
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }

            public object Current
            {
                get
                {
                    return current;
                }
            }

            public IEnumerator GetEnumerator()
            {
                return this;
            }
        }
    }
}
