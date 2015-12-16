// 2. Write a program to remove from a sequence all the integers, which
// appear odd number of times. For instance, for the sequence:
// {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6} the output would be {5, 3, 3, 5}.

namespace RemoveOddOccurings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveOddOccurings
    {
        static void Main()
        {
            List<int> sequence = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };

            List<int> extractedSequence = sequence.Where(e => sequence.Count(x => x == e) % 2 == 0).ToList();

            Console.WriteLine(string.Join(", ", extractedSequence));
        }
    }
}
