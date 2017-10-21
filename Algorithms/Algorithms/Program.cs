using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 1, 7, 0, 49, 3, 6, 2, 20, 4};
            //BubbleSort.Sort(arr);

            //InsertionSort.Sort(arr);

            //SelectionSort.Sort(arr);

            //QuickSort.Sort(arr);

            MergeSort.Sort(arr);

            Console.WriteLine(String.Join(" ", arr));

            Console.ReadLine();
        }
    }
}
