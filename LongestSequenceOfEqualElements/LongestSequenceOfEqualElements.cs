// 4. Write a method that finds the longest subsequence of equal numbers
// in a given List<int> and returns the result as new List<int>. Write a
// program to test whether the method works correctly

namespace LongestSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSequenceOfEqualElements
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 3, 2, 3, 4, 2, 2, 4 };

            int maxLength = 1, maxIndex = 0;
            int currentLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    currentLength = 0;
                }

                currentLength++;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxIndex = i - currentLength + 1;
                }
            }

            Console.WriteLine(string.Join(", ", numbers.Skip(maxIndex).Take(maxLength)));
        }
    }
}
