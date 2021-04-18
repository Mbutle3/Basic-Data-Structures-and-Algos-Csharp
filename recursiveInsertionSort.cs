using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProgramming_CSharp
{
    class InsertionSort
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            int[] intArray = { 20, 35, -15, 7, 55, 1, -22 };
 
            Console.WriteLine("Insertion Sort");

            Console.Write("Unsorted Array: [");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + "|");
            }
            Console.Write("]");


            Console.WriteLine();
            Console.Write("Sorted Array: [");

            RecursiveInsertionSort(intArray, intArray.Length);


            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + "|");
            }
            Console.Write("]");

        }



        public static void RecursiveInsertionSort(int[] input, int numItems)
        {

            //if we only have one item -> it's already sorted
            if (numItems < 2)
            {
                return;
            }

            RecursiveInsertionSort(input, numItems - 1);

            int newElement = input[numItems - 1];
            int i;

            for (i = numItems - 1; i > 0 && input[i - 1] > newElement;
                i--)
            {
                input[i] = input[i - 1];
            }

            input[i] = newElement;

        }
    }
}