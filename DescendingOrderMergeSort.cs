using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDSandAlgo
{
    using System;

    namespace LearningDSandAlgo
    {

        public class MergeSort
        {

            public static void Main(String[] args)
            {
                int[] myArray = { 20, 35, -15, 7, 55, 1, -22 };

                Console.WriteLine("Merge Sort");

                Console.Write("Unsorted: [");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(myArray[i] + "|");
                }
                mergeSort(myArray, 0, myArray.Length);

                Console.WriteLine("");

                Console.Write("Sorted: [");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(myArray[i] + "|");
                }
            }


            // [20, 35, -15, 7, 55, 1, -22] <- for reference
            public static void mergeSort(int[] input, int start, int end)
            {
                //break condition - if element is called with an one element array break
                if (end - start < 2)
                {
                    return;
                }

                int divideArrayVal = 2;

                int midpoint = (start + end) / divideArrayVal;

                /*mergesort on the left partition
                 * logical partitioning so it will always be the same input array
                 * this implementation the end index is always one greater than the last valid index in the arary
                 * indices: 0 - 3, are in the left array 
                 * {20, 30, -15 } -> {20} {35, -15} -> {20} {35} {-15}
                 * completely process left side before sorting the right array 
                */
                mergeSort(input, start, midpoint);

                /*mergesort on the right partition
                 * start at position midpoint (3)
                 * ends at position end (6) - we always pass in one greater than the last valid index in the array 
                 * indices: 3 - 6, are in the right array 
                 * {7,55,1,-22} -> {7,55} {1,-22} -> {7} {55} {1} {-22}
                */
                mergeSort(input, midpoint, end);

                /*call merge array method
                 * 
                 * 
                */
                merge(input, start, midpoint, end);

            }

            // [20, 35, -15, 7, 55, 1, -22] <- for reference
            public static void merge(int[] input, int start, int midpoint, int end)
            {
                

				/*
				Sorting In Descending Order,
				If the elemnts on the right is greater 
				than the elements on the left just return them

				*/
                if (input[midpoint - 1] >= input[midpoint])
                {
                    return;
                }

                //otherwise.. 

                int i = start;
                int j = midpoint;
                //keeps track where we are in the temporary array when copying elements
                int tempIndex = 0;

                //temporary arry with a size of end - start -> [7 - 0], can hold 7 values 
                int[] tempArray = new int[end - start];
				while (i < midpoint && j < end)
                
				
				{
                    tempArray[tempIndex++] = input[i] >= input[j] ? input[i++] : input[j++];
                }

                /*
				if the elements on the right side is greater than the elemnets 
				on the left side, save the elements on the right side first
				*/


                /*merge(int [] input, int start, int midpoint, int end) <- reference
                 * 
                 * 1st Copy:
                 *  if there's no leftover elements in the right array this does nothing 
                 *  but 
                 *  if reamain elements in the left array, copys them directly from one location 
                 *  in the input array to another location in the input array
                 * 
                 * 2nd Copy:
                 *  only copying elements we copied into the temp array 
                */

                Array.Copy(input, i, input, start + tempIndex, midpoint - i);
                Array.Copy(tempArray, 0, input, start, tempIndex);

            }
        }
    }
}