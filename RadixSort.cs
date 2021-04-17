using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDSandAlgo
{
    class CountingSort
    {
        public static void Main(String[] args) {
            int[] myArray = { 4725, 4586, 1330, 8792, 1594, 5729};

            Console.WriteLine("Radix Sort");

            Console.Write("Unsorted: [");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " | ");
            }

            Console.WriteLine("");

            RadixSort(myArray, 10, 4);

            Console.Write("Sorted: [");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " | ");
            }
        }
        
        /*For Radix Sort all values must have the same radix and width
            Width of four = four values
            Moves from least most significant digit to most significant digit 
                    Right - > Left
         */
        public static void RadixSort(int [] input, int radix, int width)
        {
            for (int i = 0; i < width; i ++)
            {
                RadixSingleSort(input, i, radix);
            }
        }

        public static void RadixSingleSort(int [] input, int position, int radix)
        {
            int numItems = input.Length;

            int[] countArray = new int[radix];
            
            foreach (int value in input)
            {
                countArray[ GetDigit(position, value, radix) ] ++;
            }

            //Adjust The Count Array
            for (int j = 1; j < radix; j++)
            {
                countArray[j] += countArray[j - 1];
            }

            int[] temp = new int[numItems];

            for(int tempIndex = numItems - 1; tempIndex >=0; tempIndex--)
            {
                temp[--countArray[GetDigit(position, input[tempIndex], radix)]] 
                    = input[tempIndex];
            }

            for (int tempIndex = 0; tempIndex < numItems; tempIndex++)
            {
                input[tempIndex] = temp[tempIndex];
            }
        }

        public static int GetDigit(int position, int value, int radix)
        {
            return value / (int)Math.Pow(radix, position) % radix;
        }

    }
}