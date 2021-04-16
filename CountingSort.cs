using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDSandAlgo
{
    class CountingSort
    {
        public static void Main(String[] args) {
            int[] myArray = { 2, 5, 9, 8, 2, 8, 7, 10, 4 };

            Console.WriteLine("Counting Sort");

            Console.Write("Unsorted: [");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " | ");
            }

            Console.WriteLine("");

            countingSort(myArray, 1,10);

            Console.Write("Sorted: [");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " | ");
            }
        }


        //Counting sort assumes all the values fall between the min and max
        public static void countingSort(int[] input, int min, int max)
        {
            /*Counting array - array that keeps track of the counts
             if min 1 max is 10, 10 - 1 is 9 so not will be counted
            which is why we add the "+1"
             */
            int[] countArray = new int[(max - min) + 1];

            for (int i = 0; i < input.Length; i++)
            {
                /*counting phase
                 * countArray at input[i] - min 
                 * min is constanly growing by one until it reaches the end of the array, 
                 */
                countArray[input[i] - min]++;
            }

            int j = 0;

            for (int i = min; i <= max; i++)
            {
                while (countArray[i - min] > 0)
                {
                    input[j++] = i;
                    countArray[i - min]--;
                }
            }
        }
    }
}