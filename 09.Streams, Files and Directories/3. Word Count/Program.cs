using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var wordsReader = new StreamReader(wordsFilePath);
            var words = new Dictionary<string, int>();
            using (wordsReader)
            {
                while (true)
                {
                    string line = wordsReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] currentLineWords = line.Split(' ');
                    foreach (string word in currentLineWords)
                    {
                        words[word] = 0;
                    }
                }
            }

            var reader = new StreamReader(textFilePath);
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string modifiedLine = line.ToLower();
                    string pattern = @"\b[a-z]+\b";
                    MatchCollection matches = Regex.Matches(modifiedLine, pattern);

                    foreach (Match match in matches)
                    {
                        if (words.ContainsKey(match.Value))
                        {
                            words[match.Value]++;
                        }
                    }
                }
            }

            var writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                var sortedWords = words.OrderByDescending(word => word.Value);
                foreach (var word in sortedWords)
                {
                    writer.WriteLine(word.Key + " - " + word.Value);
                }
            }
        }

    }
}
