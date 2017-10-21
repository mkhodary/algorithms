using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// 4. Quick Sort.
    /// </summary>
    public class QuickSort
    {
        public static void Sort(int[] arr)
        {
            QSort(arr, 0, arr.Length - 1);
        }

        private static void QSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(arr, left, right);
                QSort(arr, left, p);
                QSort(arr, p + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                do
                {
                    i = i + 1;
                } while (arr[i] < pivot);

                do
                {
                    j = j - 1;
                } while (arr[j] > pivot);

                if (i >= j)
                {
                    return j;
                }

                int res = arr[i];
                arr[i] = arr[j];
                arr[j] = res;
            }
        }
    }
}
