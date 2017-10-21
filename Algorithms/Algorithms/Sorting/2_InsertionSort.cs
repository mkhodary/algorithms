using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// 2. Insertion Sort.
    /// </summary>
    public class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int i = 1;
            while (i < arr.Length)
            {
                int j = i;

                while (j > 0 && arr[j-1] > arr[j])
                {
                    int res = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = res;

                    j = j - 1;
                }

                i = i + 1;
            }
        }
    }
}
