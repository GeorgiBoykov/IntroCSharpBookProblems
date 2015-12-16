// 14. Write a program that checks if a given number n (1 < n < 100) 
// is a prime number (i.e. it is divisible without remainder only to itself and 1).

namespace PrimeNumberCheck
{
    using System;

    public class PrimeNumberCheckMain
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input!\nEnter a number: ");
            }

            if (number == 0 || number == 1)
            {
                Console.WriteLine("Not a prime");
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("Not a prime");
                        return;
                    }
                }
                Console.WriteLine("The number is a prime!");
            }
        }
    }
}
