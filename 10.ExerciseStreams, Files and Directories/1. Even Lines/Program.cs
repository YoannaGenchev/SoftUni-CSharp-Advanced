namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                int counter = 0;
                while (true)
                {
                    string line = sr.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    if (counter % 2 == 0)
                    {
                        string modifiedLine = line
                                            .Replace('-', '@')
                                            .Replace(',', '@')
                                            .Replace('.', '@')
                                            .Replace('!', '@')
                                            .Replace('?', '@');
                        string[] words = modifiedLine.Split();
                        Array.Reverse(words);
                        string finalLine = string.Join(" ", words);
                        sb.AppendLine(finalLine);
                    }
                    counter++;
                }
            }

            return sb.ToString();
        }
    }
}

