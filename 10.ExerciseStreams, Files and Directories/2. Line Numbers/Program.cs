using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            ProcessLines(inputPath, outputPath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            int rowNumber = 0;

            using (StreamReader inputReader = new StreamReader(inputFilePath))
            {
                using (StreamWriter outputWriter = new StreamWriter(outputFilePath))
                {
                    while (!inputReader.EndOfStream)
                    {
                        string line = inputReader.ReadLine();
                        int lettersCount = 0;
                        int punctuationCount = 0;
                        foreach(var c in line)
                        {
                            if (Char.IsLetter(c))
                            {
                                lettersCount++;
                            }
                            else if (Char.IsPunctuation(c))
                            {
                                punctuationCount++;
                            }
                        }
                        outputWriter.WriteLine($"Line {++rowNumber}: {line} ({lettersCount})({punctuationCount})");
                    }
                }
            }

        }
    }
}