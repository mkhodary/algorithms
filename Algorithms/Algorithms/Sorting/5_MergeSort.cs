﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// 5. Merge Sort.
    /// </summary>
    public class MergeSort
    {
        public static void Sort(int[] arr)
        {
            TopDownMergeSort(arr, new int[arr.Length], arr.Length);
        }

        // Array A[] has the items to sort; array B[] is a work array.
        static void TopDownMergeSort(int[] A, int[] B, int n)
        {
            CopyArray(A, 0, n, B);           // duplicate array A[] into B[]
            TopDownSplitMerge(B, 0, n, A);   // sort data from B[] into A[]
        }

        // Sort the given run of array A[] using array B[] as a source.
        // iBegin is inclusive; iEnd is exclusive (A[iEnd] is not in the set).
        static void TopDownSplitMerge(int[] B, int iBegin, int iEnd, int[] A)
        {
            if (iEnd - iBegin < 2)                       // if run size == 1
                return;                                 //   consider it sorted
                                                        // split the run longer than 1 item into halves
            int iMiddle = (iEnd + iBegin) / 2;              // iMiddle = mid point
                                                            // recursively sort both runs from array A[] into B[]
            TopDownSplitMerge(A, iBegin, iMiddle, B);  // sort the left  run
            TopDownSplitMerge(A, iMiddle, iEnd, B);  // sort the right run
                                                     // merge the resulting runs from array B[] into A[]
            TopDownMerge(B, iBegin, iMiddle, iEnd, A);
        }

        //  Left source half is A[ iBegin:iMiddle-1].
        // Right source half is A[iMiddle:iEnd-1   ].
        // Result is            B[ iBegin:iEnd-1   ].
        static void TopDownMerge(int[] A, int iBegin, int iMiddle, int iEnd, int[] B)
        {
            int i = iBegin, j = iMiddle;

            // While there are elements in the left or right runs...
            for (int k = iBegin; k < iEnd; k++)
            {
                // If left run head exists and is <= existing right run head.
                if (i < iMiddle && (j >= iEnd || A[i] <= A[j]))
                {
                    B[k] = A[i];
                    i = i + 1;
                }
                else
                {
                    B[k] = A[j];
                    j = j + 1;
                }
            }
        }

        static void CopyArray(int[] A, int iBegin, int iEnd, int[] B)
        {
            for (int k = iBegin; k < iEnd; k++)
                B[k] = A[k];
        }
    }
}
