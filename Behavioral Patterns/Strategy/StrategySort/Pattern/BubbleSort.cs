using System;

namespace StrategySort
{
    class BubbleSort : Strategy
    {
        public override void Sort(int[] array)
        {
            Console.WriteLine(nameof(BubbleSort));

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = array.Length - 1; j > i; j--)
                {
                    if(array[j-1] > array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
}
