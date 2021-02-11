using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            int startIndexFileName = file.LastIndexOf("\\");
            int endIndexFileName = file.IndexOf(".");
            string fileName = file.Substring(startIndexFileName + 1, endIndexFileName - startIndexFileName - 1);
            string filExtansion = file.Substring(endIndexFileName + 1);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {filExtansion}");
        }
    }
}
