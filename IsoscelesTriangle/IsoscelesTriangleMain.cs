// 11. Write a program that prints on the console isosceles triangle which
// sides consist of the copyright character "©".

namespace IsoscelesTriangle
{
    using System;
    using System.Text;

    public class IsoscelesTriangleMain
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Enter triangle height: ");
            byte triangleHeight;

            while (!byte.TryParse(Console.ReadLine(), out triangleHeight))
            {
                Console.WriteLine("Invalid input!\nEnter triangle height: ");
            }

            char whiteSpace = ' ';
            int outerWhiteSpaceLenght = triangleHeight - 1;
            byte innerWhiteSpaceLenght = 1;
            char copyRightSymbol = '\u00A9';

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine(new string(whiteSpace, triangleHeight+1 / 2) + copyRightSymbol + new string(whiteSpace, triangleHeight+1 / 2));

            for (int i = 0; i < triangleHeight; i++)
            {
                strBuilder.Append(new string(whiteSpace, outerWhiteSpaceLenght));

                strBuilder.Append(copyRightSymbol);

                strBuilder.Append(new string(whiteSpace, innerWhiteSpaceLenght));
                
                strBuilder.Append(copyRightSymbol);

                strBuilder.Append(new string(whiteSpace, outerWhiteSpaceLenght));

                outerWhiteSpaceLenght--;
                innerWhiteSpaceLenght += 2;
                strBuilder.AppendLine();
            }

            strBuilder.AppendLine(new string(copyRightSymbol, triangleHeight*2 + 2));

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
