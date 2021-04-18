using System;
using System.Collections.Generic;
using System.Text;

namespace LearningDSandAlgo
{
    class CountingSort
    {
        public static void Main(String[] args)
        {
            string [] myArray = { "bcdef", "dbaqc", "abcde", "omadd", "bbbbb"};

            Console.WriteLine("Radix Sort");

            Console.Write("Unsorted: [");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " | ");
            }

            Console.WriteLine("");


            //26 letters in the alphabet, 5 letters in strings
            RadixSort(myArray,26,5);

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
        public static void RadixSort(string[] input, int radix, int width)
        {
            //starting i at 4 and going down to 0
            for (int i = width - 1; i >= 0; i--)
            {
                RadixSingleSort(input, i, radix);
            }
        }

        public static void RadixSingleSort(string[] input, int position, int radix)
        {
            int numItems = input.Length;

            int[] countArray = new int[radix];

            foreach (string value in input)
            {
                countArray[GetIndex(position, value)]++;
            }

            //Adjust The Count Array
            for (int j = 1; j < radix; j++)
            {
                countArray[j] += countArray[j - 1];
            }

            string[] temp = new string[numItems];

            for (int tempIndex = numItems - 1; tempIndex >= 0; tempIndex--)
            {
                temp[--countArray[GetIndex(position, input[tempIndex])]]
                    = input[tempIndex];
            }

            for (int tempIndex = 0; tempIndex < numItems; tempIndex++)
            {
                input[tempIndex] = temp[tempIndex];
            }
        }
        

        public static int GetIndex(int position, string Value)
        {
            /*You can index into a string in C# like an array, and you get the character at that index
             * lower case 'a' in ASCII has a value of 97
             *  a-97, b-98, c-99, d-100, ... 
             * upper case 'A' has a value of 65
             * 
             */
            
            return Value[ position ] - 'a' ;
        }

    }
}