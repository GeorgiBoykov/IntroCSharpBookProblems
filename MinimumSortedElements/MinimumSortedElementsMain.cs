// 22. Write a program, which reads an array of integer numbers from the console and removes 
// a minimal number of elements in such a way that the remaining array is sorted in an 
// increasing order. Example: { 6, 1, 4, 3, 0, 3, 6, 4, 5 }  { 1, 3, 3, 4, 5 }

namespace MinimumSortedElements
{
    using System;

    class MinimumSortedElementsMain
    {
        static int[] output;
        static int maxLength;

        static void Main()
        {
            Console.Write("Enter count of elements: ");
            int elementsCount;

            while (!int.TryParse(Console.ReadLine(), out elementsCount))
            {
                Console.WriteLine("Invalid input!\nEnter number of elements:");
            }

            int[] arr = new int[elementsCount];
            for (int index = 0; index < elementsCount; index++)
            {
                Console.Write("Enter element {0}: ", index + 1);

                int number;
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input! Please try again...");
                    index--;
                }
                else
                {
                    arr[index] = number;
                }
            }

            output = new int[elementsCount];
            int[] subset = new int[elementsCount];
            for (int elementsInSubset = 1; elementsInSubset <= elementsCount; elementsInSubset++)
            {
                GenerateSubset(arr, subset, 0, 0, elementsInSubset);
            }

            for (int i = 0; i <= maxLength; i++)
            {
                Console.WriteLine("{0} ", output[i]);
            }
        }

        static void GenerateSubset(int[] arr, int[] subset, int index, int current, int elementsInSubset)
        {
            if (index == elementsInSubset)
            {
                CheckSubsets(subset, elementsInSubset);
                return;
            }

            for (int i = current; i < arr.Length; i++)
            {
                subset[index] = arr[i];
                GenerateSubset(arr, subset, index + 1, i + 1, elementsInSubset);
            }
        }

        static void CheckSubsets(int[] subset, int elementsInSubset)
        {
            for (int i = 1; i < elementsInSubset; i++)
            {
                if (subset[i] < subset[i - 1])
                {
                    return;
                }
                if (i > maxLength)
                {
                    maxLength = i;
                    for (int j = 0; j <= maxLength; j++)
                    {
                        output[j] = subset[j];
                    }
                }
            }
        }
    }
}
