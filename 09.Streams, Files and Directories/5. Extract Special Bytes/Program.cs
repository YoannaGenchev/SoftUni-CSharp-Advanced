using System.Reflection.PortableExecutable;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            HashSet<byte> bytes = new HashSet<byte>();
            using (var bytesReader = new StreamReader(bytesFilePath))
            {
                while (true)
                {
                    string line = bytesReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    byte current = byte.Parse(line);
                    bytes.Add(current);
                }
            }

            using (var imgReader = new FileStream(binaryFilePath, FileMode.Open))
            using (var outpuWriter = new FileStream(outputPath, FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int bytesRead = imgReader.Read(buffer);
                    if (bytesRead == 0) break;
                    List<byte> bytesToWrite = new List<byte>();
                    for (int i = 0; i < bytesRead; i++)
                    {
                        if (bytes.Contains(buffer[i]))
                        {
                            bytesToWrite.Add(buffer[i]);
                        }
                    }
                    outpuWriter.Write(bytesToWrite.ToArray(), 0, bytesToWrite.Count);
                }
            }

        }
    }
}

