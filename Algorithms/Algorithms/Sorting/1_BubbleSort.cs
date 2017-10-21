using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// 1. Bubble Sorting.
    /// </summary>
    public class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            bool isSwapped;
            do
            {
                isSwapped = false;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        int res = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = res;

                        isSwapped = true;
                    }
                }
            } while (isSwapped);
        }
    }
}
