﻿namespace CopyDirectory
{
    using System;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }

            if (!Directory.Exists(inputPath))
            {
                return;
            }

            Directory.CreateDirectory(outputPath);
            var files = Directory.GetFiles(inputPath);
            foreach (var file in files )
            {
                var fileName = Path.GetFileName(file);
                var destination = Path.Combine(outputPath, fileName);
                File.Copy(file, destination);
            }
        }
    }
}

