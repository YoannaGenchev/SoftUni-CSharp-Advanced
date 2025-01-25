namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sum = 0;
            DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
            FileInfo[] infos = folderInfo.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo fileInfo in infos)
            {
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;
            File.WriteAllText(outputFilePath, sum.ToString());
        }
    }
}

