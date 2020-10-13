using System;
using System.IO;

namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent = File.ReadAllText("Textexample.txt");
            Console.WriteLine(fileContent);
        }

        public void LearnFileWriting()
        {
            File.WriteAllText("Example.txt", "another example");
        }

        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("Example.txt");
            var x = fileInfo.Length;
            Console.WriteLine($"file size: {x} bytes");
        }

        internal void LearnDirectory()
        {
            Directory.CreateDirectory("abc");
            File.WriteAllText(@"abc\a.html", "html file");
        }

        internal void LearnDirectoryInfo()
        {
            string folderPath = @"D:\NJB\files\csit\dotnet\Bijen-Shrestha";
            DirectoryInfo  directory = new DirectoryInfo(folderPath);
            var files = directory.GetFiles();
            Console.WriteLine("File count: " + files.Length);
        }
    }
}