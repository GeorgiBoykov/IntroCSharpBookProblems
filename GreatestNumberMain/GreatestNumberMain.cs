// 7. Write a program that finds the greatest of given 5 numbers. 

namespace GreatestNumberMain
{
    using System;

    public class GreatestNumberMain
    {
        static void Main()
        {
            decimal[] numbers = new decimal[5];

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Number #{0}:", i);

                decimal n;
                if (!decimal.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Invalid input! Please enter another number.");
                    i--;
                }
                else
                {
                    numbers[i] = n;
                }
            }

            decimal greatestNumber = decimal.MinValue;

            foreach (decimal number in numbers)
            {
                if (number > greatestNumber)
                {
                    greatestNumber = number;
                }    
            }

            Console.WriteLine("The greatest number is: {0}", greatestNumber);
        }
    }
}
