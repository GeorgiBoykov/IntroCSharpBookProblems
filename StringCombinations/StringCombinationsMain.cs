// 5. Write a recursive program, which prints all subsets of a given set of
// N words. Example input:
// words = {"test", "rock", "fun"}
// Example output:
// (), (test), (rock), (fun), (test rock), (test fun),
// (rock fun), (test rock fun)


namespace StringCombinations
{
    using System;

    public class StringCombinationsMain
    {
        static string[] words;

        static void Main()
        {
            Console.Write("Enter array size: ");
            int arraySize;

            while (!int.TryParse(Console.ReadLine(), out arraySize))
            {
                Console.WriteLine("Invalid input!\nEnter array size: ");
            }

            words = new string[arraySize];
            string inputLine;
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("Enter word[{0}]: ", i);
                inputLine = Console.ReadLine();
                words[i] = inputLine;
            }

            for (int i = 0; i < 3; i++)
            {
                int[] array = new int[i];
                FindCombinations(array, 0, 0, arraySize);
            }
        }

        private static void FindCombinations(int[] words, int index, int start, int end)
        {
            if (index >= words.Length)
            {
                Print(words);
            }
            else
            {
                for (int i = start; i < end; i++)
                {
                    words[index] = i;
                    FindCombinations(words, index + 1, i + 1, end);
                }
            }
        }

        private static void Print(int[] words)
        {
            Console.Write("(");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("{0}", StringCombinationsMain.words[words[i]]);
                if (i != words.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.Write(")");
            Console.WriteLine();
        }
    }
}
