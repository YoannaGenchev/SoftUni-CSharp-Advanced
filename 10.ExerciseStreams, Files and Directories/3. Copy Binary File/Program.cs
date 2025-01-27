namespace CopyBinaryFile
{
    using System;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (var imgReader = new FileStream(inputFilePath, FileMode.Open))
            using (var outpuWriter = new FileStream(outputFilePath, FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int bytesRead = imgReader.Read(buffer);
                    if (bytesRead == 0) break;
                    outpuWriter.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}

