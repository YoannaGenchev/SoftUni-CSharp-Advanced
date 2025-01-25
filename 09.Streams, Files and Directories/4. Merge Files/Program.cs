namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader input1Reader = new StreamReader(firstInputFilePath))
            {
                using (StreamReader input2Reader = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter outputWriter = new StreamWriter(outputFilePath))
                    {
                        while (!input1Reader.EndOfStream || !input2Reader.EndOfStream)
                        {
                            string line1 = input1Reader.ReadLine();
                            if (line1 != null)
                            {
                                outputWriter.WriteLine(line1);
                            }

                            string line2 = input2Reader.ReadLine();
                            if (line2 != null)
                            {
                                outputWriter.WriteLine(line2);
                            }
                        }
                    }
                }
            }
        }
    }
}

