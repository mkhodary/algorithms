using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// 3. Selectoin Sort.
    /// </summary>
    public class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        // New minimum found, remember its index.
                        min = j;
                    }
                }

                if (min != i)
                {
                    int res = arr[min];
                    arr[min] = arr[i];
                    arr[i] = res;
                }
            }
        }
    }
}
