//12. Write a program that converts Arabic digits to Roman ones.

namespace ArabicToRoman
{
    using System;

    class ArabicToRomanMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 3999:");

            Console.Write("Enter a number: ");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input!\nPlease enter a number between 1 and 3999:");
            }

            if ((number < 1) || (number > 3999))
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine(ToRoman(number));
            }
        }

        private static string ToRoman(int number)
        {
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);

            return string.Empty;
        }
    }
}
