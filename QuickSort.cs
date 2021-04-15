using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDSandAlgo
{
    class QuickSort
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Quick Sort");

            int[] myArray = { 20, 25, -15, 7, 15, 1, -22 };

            Console.Write("Unsorted: [");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " | ");
            }

            Console.WriteLine("");

            quickSort(myArray, 0, myArray.Length);

            Console.Write("Sorted: [");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " | ");
            }
        }

        public static void quickSort(int[] input, int start, int end)
        {
            //check if dealing with one element array
            if (end - start < 2)
            {
                return;
            }

            //otherwise

            /*return pos of piviot 
             *everything left of pivot is smaller than the pivot.
             *everything right of pivot is larger than the pivot.
             */
            int pivotIndex = partition(input, start, end);

            /*quick sort the left side of the sub array
            */
            quickSort(input, start, pivotIndex);

            /*quick sort right side of the sub array
            */
            quickSort(input, pivotIndex + 1, end);

            /*after completing these two quickSort calls, the entire array would be sorted
             Recursive calls so the left sub side must be completly sorted before, program will move on to the right sub arry*/


        }



        public static int partition(int[] input, int start, int end)
        {
            /*Purpose: returns the correct position of the pivot in the sorted array
             *Using the First Element As The Pivot
             start = start element in the array OR sub array, so will not remain index 0. 
             */

            int pivot = input[start];
            int i = start;
            int j = end;

            /* i traverse left - > right 
             * j traverse right -> left
             *  we want to stop when, i and j cross each other
            */

            while (i < j)
            {
                /*NOTE:// empty loop body
                 * Only using this loop to decriment j until we find an element less than the pivot
                 * OR 
                 * j crosses i ex: ( i > j)
                 */
        while (i < j && input[--j] >= pivot) ;

                if (i < j)
                {
                    /*Using j to find the first element less than the pivot
                     * moving that found element position at [j] to position [i]
                     * ex: first iteration, -22, will replace, 20, and be moved to position 0
                     */
                    input[i] = input[j];
                }

                /*traversing array left to right
                 * looking for the first element greater than the pivot
                 */
                /*NOTE:// empty loop body
                * Only using this loop to incriment i until we find an element greater than the pivot
                * OR 
                * i crosses j ex: ( i  j)
                */
        while (i < j && input[++i] <= pivot) ;

                if (i < j)
                {
                    input[j] = input[i];
                }
            }
            input[j] = pivot;
            return j;
        }
    } 
} 