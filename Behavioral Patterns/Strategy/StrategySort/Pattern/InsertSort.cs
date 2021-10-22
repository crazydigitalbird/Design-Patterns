using System;

namespace StrategySort
{
    class InsertSort : Strategy
    {
        public override void Sort(int[] array)
        {
            Console.WriteLine(nameof(InsertSort));

            for(int i = 0; i < array.Length; i++)
            {
                int j = 0;
                int buffer = array[i];

                for(j = i - 1; j >= 0; j--)
                {
                    if(array[j] < buffer)
                    {
                        break;
                    }

                    array[j + 1] = array[j];
                }

                array[j + 1] = buffer;
            }
        }
    }
}
