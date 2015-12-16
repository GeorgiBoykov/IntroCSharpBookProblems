//9. Write a method that finds the biggest element of an array. Use that
//method to implement sorting in descending order.

namespace BiggestElement
{
    using System;

    public class BiggestElement
    {
        static void Main()
        {
            int[] elements = new[] { -2147483648, 1, 4, 6, 5, 3, -1, 1, 5, 2, 7, 1, 2147483647, -2147483648 };

            Sort(ref elements);

            Console.WriteLine(string.Join(", ", elements));
        }

        private static int FindBiggest(int[] array)
        {
            int biggest = int.MinValue;

            foreach (int element in array)
            {
                if (element > biggest)
                {
                    biggest = element;
                }
            }

            return biggest;
        }

        private static void Sort(ref int[] array)
        {
            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int biggestElement = FindBiggest(array);
                result[i] = biggestElement;
                int firstFoundIndex = Array.IndexOf(array, biggestElement);

                array[firstFoundIndex] = int.MinValue;
            }

            array = result;
        }
    }
}
