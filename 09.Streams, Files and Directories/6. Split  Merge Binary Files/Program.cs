namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (var sourceReader = new FileStream(sourceFilePath, FileMode.Open))
            using (var outpu1Writer = new FileStream(partOneFilePath, FileMode.Create))
            using (var outpu2Writer = new FileStream(partTwoFilePath, FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int bytesRead = sourceReader.Read(buffer);
                    if (bytesRead == 0) break;
                    List<byte> bytesToWrite1 = new List<byte>();
                    List<byte> bytesToWrite2 = new List<byte>();
                    for (int i = 0; i < bytesRead; i++)
                    {
                        if (i % 2 == 0)
                        {
                            bytesToWrite1.Add(buffer[i]);
                        }
                        else
                        {
                            bytesToWrite2.Add(buffer[i]);
                        }
                    }

                    outpu1Writer.Write(bytesToWrite1.ToArray(), 0, bytesToWrite1.Count);
                    outpu2Writer.Write(bytesToWrite2.ToArray(), 0, bytesToWrite2.Count);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (var source1Reader = new FileStream(partOneFilePath, FileMode.Open))
            using (var source2Reader = new FileStream(partTwoFilePath, FileMode.Open))
            using (var outputWriter = new FileStream(joinedFilePath, FileMode.Create))
            {
                byte[] buffer1 = new byte[4096];
                byte[] buffer2 = new byte[4096];
                while (true)
                {
                    int bytes1Read = source1Reader.Read(buffer1);
                    if (bytes1Read == 0) break;
                    int bytes2Read = source2Reader.Read(buffer2);
                    if (bytes2Read == 0) break;
                    List<byte> bytesToWrite = new List<byte>();
                    for (int i = 0; i < Math.Max(bytes1Read, bytes2Read); i++)
                    {
                        if (i < bytes1Read)
                        {
                            bytesToWrite.Add(buffer1[i]);
                        }
                        if (i < bytes2Read)
                        {
                            bytesToWrite.Add(buffer2[i]);
                        }
                    }

                    outputWriter.Write(bytesToWrite.ToArray(), 0, bytesToWrite.Count);
                }
            }
        }
    }
}

