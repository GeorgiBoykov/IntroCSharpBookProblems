// 24. Write a program that reads a string from the console and replaces every
// sequence of identical letters in it with a single letter (the repeating
// letter). Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

namespace RemoveRepeatingLetters
{
    using System;
    using System.Text;

    class RemoveRepeatingLettersMain
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            output.Append(input[0]);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != output[output.Length - 1])
                {
                    output.Append(input[i]);
                }   
            }

            Console.WriteLine(output.ToString());
        }
    }
}
