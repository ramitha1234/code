using System;
using System.IO;

namespace ReadingWritingCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\mahagosaiwarr\OneDrive - Broadridge Financial Solutions, Inc\Documents\myusers.csv";
            StreamReader reader = null;

            // Check if the file exists
            if (File.Exists(path))
            {
                // Use the StreamReader to open the file
                reader = new StreamReader(File.OpenRead(path));
                // Loop to ensure we process each line of the file until we reach the end
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Console.WriteLine("Hello {0}", values[0]);
                }
            }
            else
            {
                Console.WriteLine("The file doesn't exist");
            }
        }
    }
}