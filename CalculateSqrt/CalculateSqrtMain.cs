// 7. Write a program that takes a positive integer from the console and prints
// the square root of this integer. If the input is negative or invalid print
// "Invalid Number" in the console. In all cases print "Good Bye".

namespace CalculateSqrt
{
    using System;

    public class CalculateSqrtMain
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to calculate its sqrt");
            CalculateSQRT();
        }

        private static void CalculateSQRT()
        {
            double sqrtN;

            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                sqrtN = Math.Sqrt(n);
                Console.WriteLine(sqrtN);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid Number");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
