using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_FileSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dir = @"C:\Code\Ch10_Example\";
            var textFile = "Ch10.txt";
            var backupFile = "Ch10.bak";

            Console.WriteLine($"Does {dir} exists? {Directory.Exists(dir)}");

            Directory.CreateDirectory(dir);

            Console.WriteLine($"Does {dir} exists? {Directory.Exists(dir)}");

            Console.WriteLine($"Does {textFile} exists? {File.Exists(dir + textFile)}");

            using (var textWriter = File.CreateText(dir + textFile))
            {
                textWriter.WriteLine("Hello C#!");
            }

            Console.WriteLine($"Does {textFile} exists? {File.Exists(dir + textFile)}");

            Directory.Delete(dir);

            Console.WriteLine($"Does {dir} exists? {Directory.Exists(dir)}");

            Console.ReadLine();
        }
    }
}