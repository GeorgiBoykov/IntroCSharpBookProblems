// 16. Write a program that by a given integer N prints the numbers from 1 to N in random order. 

namespace RandomSequence
{
    using System;

    public class RandomSequenceMain
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid input! Please try again");
            }

            int[] sequence = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                sequence[i] = i;
            }

            for (int i = 0; i < n / 2; i++)
            {
                int rndPosition1 = rnd.Next(sequence.Length);
                int rndPosition2 = rnd.Next(sequence.Length);

                Swap(ref sequence[rndPosition1], ref sequence[rndPosition2]);
            }

            Console.WriteLine(string.Join(", ", sequence));
        }

        private static void Swap(ref int firstElement, ref int secondElement)
        {
            int tempElement = firstElement;
            firstElement = secondElement;
            secondElement = tempElement;
        }
    }
}
