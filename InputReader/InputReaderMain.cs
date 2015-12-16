// 1. Take the code from the first example in this chapter and refactor it to
// meet the quality standards discussed in this chapter.

namespace InputReader
{
    using System;

    class InputReaderMain
    {
        private static void Main()
        {
            Console.WriteLine("Please select a number in the range [1..10]");

            ConsoleKeyInfo input = Console.ReadKey();

            while (input.Key != ConsoleKey.Escape)
            {
                int selection = ParseInput(input.KeyChar);
                PrintSelection(selection);

                input = Console.ReadKey();
            }
        }

        private static int ParseInput(char input)
        {
            int selection;
            int.TryParse(input.ToString(), out selection);

            return selection;
        }

        private static void PrintSelection(int selection)
        {
            switch (selection)
            {
                case 10:
                    Console.WriteLine("\nYou selected: TEN");
                    break;
                case 9:
                    Console.WriteLine("\nYou selected: NINE");
                    break;
                case 8:
                    Console.WriteLine("\nYou selected: EIGHT");
                    break;
                case 7:
                    Console.WriteLine("\nYou selected: SEVEN");
                    break;
                case 6:
                    Console.WriteLine("\nYou selected: SIX");
                    break;
                case 5:
                    Console.WriteLine("\nYou selected: FIVE");
                    break;
                case 4:
                    Console.WriteLine("\nYou selected: FOUR");
                    break;
                case 3:
                    Console.WriteLine("\nYou selected: THREE");
                    break;
                case 2:
                    Console.WriteLine("\nYou selected: TWO");
                    break;
                case 1:
                    Console.WriteLine("\nYou selected: ONE");
                    break;
                default:
                    Console.WriteLine("\nWrong input!");
                    break;
            }
        }
    }
}
