// 8. Write a program that reads five integer numbers and prints their sum. 
// If an invalid number is entered the program should prompt the user to enter another number

namespace SumOfFiveNumbers
{
    using System;

    public class SumOfFiveNumbersMain
    {
        static void Main()
        {
            int sum = 0;

            Console.WriteLine("Enter five numbers to calculate their sum: ");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Number #{0}:", i);
                
                int number;
                
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input! Please enter another number.");
                    i--;
                }
                else
                {
                    sum += number;
                }
            }

            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
