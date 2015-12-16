// 09. Write a program that deletes all the odd lines of a text file.

namespace DeleteOddLines
{
    using System.IO;
    using System.Text;

    public class DeleteOddLinesMain
    {
        static void Main()
        {
            string line = null;
            int lineNumber = 0;
            string path = "../sampleFile.txt";

            StringBuilder strBuilder = new StringBuilder();

            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        strBuilder.AppendLine(line);
                    }
                    else
                    {
                        strBuilder.AppendLine(string.Empty);
                    }

                    lineNumber++;
                }
            }

            File.WriteAllText(path, strBuilder.ToString());

            System.Console.WriteLine("Task Completed...");
        }
    }
}
