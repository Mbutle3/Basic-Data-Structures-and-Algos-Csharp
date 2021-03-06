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
            mergeSort(input,midpoint,end);

            /*call merge array method
             * 
             * 
            */
            merge(input, start, midpoint, end);

        }

        // [20, 35, -15, 7, 55, 1, -22] <- for reference
        public static void merge(int [] input, int start, int midpoint, int end)
        {
            /*
             * if the last element on the left array is less than or equal to 
             * the first element on the right side, then that means all the elements in the left partition 
             * are less than or equal to the first element in the right array. Both arrays are already sorted.
             */
            if(input[midpoint - 1] <= input[midpoint])
            {
                return;
            }

            //otherwise.. 

            int i = start;
            int j = midpoint;
            //keeps track where we are in the temporary array when copying elements
            int tempIndex = 0;

            //temporary arry with a size of end - start -> [7 - 0], can hold 7 values 
            int[] tempArray = new int [end - start];

            /*step through left and right arrays 
            comparing what's at index[i] in the left array, with what's at index[j] in the right array 
            write the smaller of the two inside the current position of temp
            
            currently: i = 0, midpoint = 3 j = 3 < end = 7
                when i == mid we would have finished traversing the first array
            */  
            while(i < midpoint && j < end)
            {
                /*
                 *assuming that haven't happened yet we are going to compare the current element
                 *in the left partition to the current element in the right partition
                 *
                 *then we are going to write the smaller of the two to the tempArary 
                 *
                 *if we didn't have "<=" algorithm would be come unstable
                 *
                 *if input[i] is <= input[j] 
                 *we are going to assign input[i] to tempArray[tempIndex] 
                 *and then increment the tempIndex by 1 , and i by 1
                 *else
                 *if input[i] is > input[j] 
                 *we are going to assign input[j] to tempArray[tempIndex] 
                 *and then increment the tempIndex by 1 , and j by 1
                 *
                 *we always write the smallest element to tempArray
                */
                tempArray[tempIndex++] = input[i] <= input[j] ? input[i++] : input[j++];
            }

            /*handling remaining elements
             * if we have elements remaining in the left array 
             * we have to copy them into the tempArray
             * but
             * if we have elements remaining in the right array
             * we don't have to do anything, because if we have elements in the right array
             * then that element is already greater than everything that has already been copied
             *
             *always merging sorted arrays elemtns {least in array <-> greatest in array}
             *    Right array
             *ex: {32, 34}, {33, 36} 
             *    {32, 33, 34} -no point in copying 36 to temp array, 36 position doesn't change
             *    
             *    Left array
             *ex: {32, 36}, {33, 34}   
             *     {32, 33,34, 36} <- 36 position changes from left pos(1) to pos(3)
             *     
             *     
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

            Array.Copy(input,i,input, start + tempIndex, midpoint - i);
            Array.Copy(tempArray, 0, input, start, tempIndex);

        }
    }
}