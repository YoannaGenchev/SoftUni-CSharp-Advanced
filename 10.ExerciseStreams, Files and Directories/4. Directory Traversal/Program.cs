namespace DirectoryTraversal
{
    using System;
    using System.Reflection.Metadata;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }
        static string GetFileExtension(string fileName)
        {
            return fileName.Contains('.') ? fileName.Substring(fileName.LastIndexOf('.') + 1) : "";
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            List<string> files = new List<string>();
            DirectoryInfo folderInfo = new DirectoryInfo(inputFolderPath);
            FileInfo[] infos = folderInfo.GetFiles("*", SearchOption.TopDirectoryOnly);
            foreach (FileInfo fileInfo in infos)
            {
                files.Add(fileInfo.FullName);
            }

            var orderedFiles = files
                                .GroupBy(file => GetFileExtension(file))
                                .OrderByDescending(group => group.Count())
                                .ThenBy(group => group.Key)
                                .SelectMany(group => group.OrderBy(file => file))
                                .ToList();

            return string.Join("\n", orderedFiles);
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, reportFileName);
            File.WriteAllText(filePath, textContent);
        }
    }
}

