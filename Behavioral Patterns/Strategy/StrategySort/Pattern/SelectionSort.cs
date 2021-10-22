using System;

namespace StrategySort
{
    class SelectionSort : Strategy
    {
        public override void Sort(int[] array)
        {
            Console.WriteLine(nameof(SelectionSort));

            for(int i = 0; i < array.Length - 1; i++)
            {
                int k = i;

                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[k] > array[j])
                    {
                        k = j;
                    }
                }

                if(i != k)
                {
                    int temp = array[i];
                    array[i] = array[k];
                    array[k] = temp;
                }
            }
        }
    }
}
