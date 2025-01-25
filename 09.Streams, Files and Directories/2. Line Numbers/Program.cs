using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath,outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            int rowNumber = 0;

            using (StreamReader inputReader = new StreamReader(inputFilePath))
            {
                using (StreamWriter outputWriter = new StreamWriter(outputFilePath))
                {
                    while (!inputReader.EndOfStream)
                    {
                        string line = inputReader.ReadLine();
                        outputWriter.WriteLine($"{++rowNumber}. {line}");
                    }
                }
            }

        }
    }
}
